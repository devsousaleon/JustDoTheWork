using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Forms;
using JustDoTheWork.UI.Core;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class HistoricoUserControl : XtraUserControl
    {
        private readonly ProjetoController _projetoController;
        private readonly AtividadeController _atividadeController;
        private readonly ModeloRelatorioController _modeloRelatorioController;

        public HistoricoUserControl()
        {
            InitializeComponent();
            DesignGrid.Configurar(gridHistorico, (colNomeAtividade, 420), (colNomeProjeto, 300), (colDataInicioExecucao, 200), (colDataFimExecucao, 200));
            _projetoController = CompositionRoot.CriarProjetoController();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _modeloRelatorioController = CompositionRoot.CriarModeloRelatorioController();
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

        void btnImprimirHistorico_Click(object sender, EventArgs e)
        {
            var buscaTextoModelo = _modeloRelatorioController.BuscarModeloHistoricoExecucao();

            if (buscaTextoModelo == null)
            {
                MessageService.Atencao("Não foi encontrado modelo ativo para impressão!");
                return;
            }

            using var conversor = new RichEditControl();
            conversor.LoadDocument(buscaTextoModelo, DocumentFormat.OpenXml);
            
            var textoRtf = conversor.RtfText;

            FormEditaTexto formEditaTexto = new(textoRtf);
            formEditaTexto.ShowDialog();
        }
    }
}
