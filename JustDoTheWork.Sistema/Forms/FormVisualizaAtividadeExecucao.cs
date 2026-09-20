using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
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
            bindingSourceExecucaoDTO.DataSource = _execucaoController.InformaDadosExecucao(_homeUserControl.IdSelecionadoAtividade);
            bindingSourceVisualizaExecucaoAtividadeDTO.DataSource = _execucaoController.InformaDadosAtividade(_homeUserControl.IdSelecionadoAtividade);
        }
    }
}