using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Forms;
using JustDoTheWork.Sistema.Services;
using JustDoTheWork.UI.Core;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class HistoricoUserControl : XtraUserControl
    {
        private readonly ProjetoController _projetoController;
        private readonly AtividadeController _atividadeController;
        private readonly ModeloRelatorioController _modeloRelatorioController;
        private readonly int? _usuarioId;

        public HistoricoUserControl() : this(null)
        {
        }

        public HistoricoUserControl(int? usuarioId)
        {
            InitializeComponent();
            _usuarioId = usuarioId;
            DesignGrid.Configurar(gridHistorico, (colNomeAtividade, 420), (colNomeProjeto, 300), (colDataInicioExecucao, 200), (colDataFimExecucao, 200));
            _projetoController = CompositionRoot.CriarProjetoController();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _modeloRelatorioController = CompositionRoot.CriarModeloRelatorioController();
            btnImprimirHistorico.Visible = CompositionRoot.UsuarioAtual?.PodeGerenciarModelos == true;
            var colUsuario = gridHistorico.Columns.AddVisible("Usuario", "Autor da execução");
            var colEtapa = gridHistorico.Columns.AddVisible("NomeEtapa", "Etapa da execução");
            DesignGrid.Configurar(gridHistorico, (colUsuario, 180), (colEtapa, 145));
        }

        void HistoricoUserControl_Load(object sender, EventArgs e)
        {
            AtualizaComboBoxProjeto();
            AtualizaComboBoxStatus();
        }

        void AtualizaComboBoxProjeto()
            => UIMethodsService.AtualizaComboBoxProjeto(_projetoController, comboProjetoPesquisa);

        void AtualizaComboBoxStatus()
            => UIMethodsService.AtualizaComboBoxStatus(_atividadeController, comboStatusPesquisa);

        void btnPesquisarHistorico_Click(object sender, EventArgs e)
        {
            var filtroPesquisa = new FiltroPesquisaHistoricoDTO
            {
                ProjetoId = comboProjetoPesquisa.EditValue != null ? (int?)comboProjetoPesquisa.EditValue : null,
                Status = comboStatusPesquisa.EditValue != null ? (int?)comboStatusPesquisa.EditValue : null,
                DataCriacaoAtividade = dataCriacaoPesquisa.EditValue != null ? dataCriacaoPesquisa.DateTime.Date : null
            };

            var resultadoFiltro = _atividadeController.PesquisarHistorico(filtroPesquisa);

            gridControlHistorico.DataSource = resultadoFiltro;
        }

        void btnLimpar_Click(object sender, EventArgs e)
        {
            comboProjetoPesquisa.EditValue = null;
            comboStatusPesquisa.EditValue = null;
            dataCriacaoPesquisa.EditValue = null;
        }

        int[] ObtemExecucaoIdsImpressao()
            => Enumerable.Range(0, gridHistorico.DataRowCount)
                .Select(linha => gridHistorico.GetRow(linha))
                .OfType<ResultadoPesquisaHistoricoDTO>()
                .Select(execucao => execucao.ExecucaoId)
                .ToArray();

        void btnImprimirHistorico_Click(object sender, EventArgs e)
        {
            var execucaoIds = ObtemExecucaoIdsImpressao();
            if (execucaoIds.Length == 0)
            {
                MessageService.Atencao("Pesquise as execuções que deseja imprimir antes de gerar o relatório.");
                return;
            }

            try
            {
                var modeloId = SelecionarModelo();
                if (!modeloId.HasValue) return;
                UseWaitCursor = true;
                var dados = _modeloRelatorioController.BuscarDadosImpressaoHistorico(execucaoIds, _usuarioId, modeloId);
                var textoRtf = ImpressaoHistoricoService.GerarDocumento(dados);
                UseWaitCursor = false;
                using var formEditaTexto = new FormEditaTexto(textoRtf, somenteLeitura: true);
                formEditaTexto.ShowDialog(FindForm());
            }
            catch (InvalidOperationException erro)
            {
                MessageService.Atencao(erro.Message);
            }
            catch (Exception)
            {
                MessageService.Erro("Não foi possível gerar o relatório do histórico. Verifique a conexão com o banco e o texto do modelo.");
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        int? SelecionarModelo()
        {
            var modelos = _modeloRelatorioController.PesquisarModelosHistorico().ToList();
            if (modelos.Count == 0) throw new InvalidOperationException("Nenhum modelo ativo de Histórico Execução foi encontrado.");
            if (modelos.Count == 1) return modelos[0].Id;
            using var formulario = new XtraForm { Text = "Selecionar modelo de impressão", ClientSize = new Size(480, 160), FormBorderStyle = FormBorderStyle.FixedDialog, StartPosition = FormStartPosition.CenterParent, MaximizeBox = false, MinimizeBox = false };
            using var combo = new LookUpEdit { EnterMoveNextControl = true, Location = new Point(20, 40), Size = new Size(440, 30) };
            combo.Properties.DataSource = modelos;
            combo.Properties.DisplayMember = nameof(ResultadoPesquisaModeloRelatorioDTO.Descricao);
            combo.Properties.ValueMember = nameof(ResultadoPesquisaModeloRelatorioDTO.Id);
            combo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(nameof(ResultadoPesquisaModeloRelatorioDTO.Descricao), "Modelo"));
            combo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            combo.EditValue = modelos[0].Id;
            using var confirmar = new SimpleButton { Text = "Confirmar", Location = new Point(252, 105), Size = new Size(100, 30), DialogResult = DialogResult.OK };
            using var cancelar = new SimpleButton { Text = "Cancelar", Location = new Point(360, 105), Size = new Size(100, 30), DialogResult = DialogResult.Cancel };
            formulario.AcceptButton = confirmar;
            formulario.CancelButton = cancelar;
            formulario.Controls.AddRange([combo, confirmar, cancelar]);
            return formulario.ShowDialog(FindForm()) == DialogResult.OK ? combo.EditValue as int? : null;
        }
    }
}
