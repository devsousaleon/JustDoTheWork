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
        private readonly ModeloRelatorioController _modeloRelatorioControler;

        public HistoricoUserControl()
        {
            InitializeComponent();
            _projetoController = CompositionRoot.CriarProjetoController();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _modeloRelatorioControler = CompositionRoot.CriarModeloRelatorioController();
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
                DataCriacaoAtividade = DataCriacao.EditValue != null ? (DateTime?)DataCriacao.DateTime.Date : null
            };

            var resultadoFiltro = _atividadeController.PesquisarParaGridVisualizaHistorico(filtroPesquisa);

            gridControlHistorico.DataSource = resultadoFiltro;
        }

        void btnLimpar_Click(object sender, EventArgs e)
        {
            comboProjetoPesquisa.EditValue = null;
            comboStatusPesquisa.EditValue = null;
            DataCriacao.EditValue = null;
        }

        void btnImprimirHistorico_Click(object sender, EventArgs e)
        {
            var buscaTextoModelo = _modeloRelatorioControler.BuscaModeloHistoricoExecucao();

            if (buscaTextoModelo == null)
            {
                MessageService.Mensagem_Atencao("Não foi encontrado modelo ativo para impressão!");
                return;
            }

            using var conversor = new RichEditControl();
            conversor.LoadDocument(buscaTextoModelo, DocumentFormat.OpenXml);
            
            var textoRtf = conversor.RtfText;

            FormEditaTextoAtividade formEditaTextoAtividade = new(textoRtf);
            formEditaTextoAtividade.ShowDialog();
        }
    }
}