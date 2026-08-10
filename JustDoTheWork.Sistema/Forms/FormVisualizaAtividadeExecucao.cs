using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.Sistema.ControlPanel;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormVisualizaAtividadeExecucao : XtraForm
    {
        private readonly ExecucaoController _execucaoController;
        private readonly VisualizaExecucaoUserControl _homeUserControl;

        public FormVisualizaAtividadeExecucao(VisualizaExecucaoUserControl homeUserControl)
        {
            InitializeComponent();
            _execucaoController = CompositionRoot.CriarExecucaoController();
            _homeUserControl = homeUserControl;
        }

        void FormVisualizaAtividadeExecucao_Load(object sender, EventArgs e)
            => CarregaInfoAtividadeExecucao();

        void CarregaInfoAtividadeExecucao()
        {
            var dadosInfoExecucao = _execucaoController.InformaDadosExecucao(_homeUserControl.IdSelecionadoAtividade);
            dataGridHistoricoExecucao.DataSource = dadosInfoExecucao;

            var dadosInfoAtividade = _execucaoController.InformaDadosAtividade(_homeUserControl.IdSelecionadoAtividade);
            txtEditorAtividade.LoadDocument(dadosInfoAtividade.DescricaoAtividade, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
            txtNomeAtividade.Text = dadosInfoAtividade.NomeAtividade;
            txtNomeProjeto.Text = dadosInfoAtividade.NomeProjeto;
            DataCriacaoAtividade.EditValue = dadosInfoAtividade.DataCriacaoAtividade;
        }
    }
}