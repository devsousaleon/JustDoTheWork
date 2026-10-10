using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.Sistema.ControlPanel;
using JustDoTheWork.UI.Core;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormVisualizaAtividadeExecucao : XtraForm
    {
        private readonly ExecucaoController _execucaoController;
        private readonly VisualizaExecucaoUserControl _visualizaExecucaoUserControl;

        public FormVisualizaAtividadeExecucao(VisualizaExecucaoUserControl visualizaExecucaoUserControl)
        {
            InitializeComponent();
            DesignGrid.Configurar(gridHistoricoExecucao, (colAtividadeId, 70), (colDataInicioExecucao, 240), (colDataFimExecucao, 240));
            _execucaoController = CompositionRoot.CriarExecucaoController();
            _visualizaExecucaoUserControl = visualizaExecucaoUserControl;
        }

        void FormVisualizaAtividadeExecucao_Load(object sender, EventArgs e)
            => CarregaDadosAtividadeExecucao();

        void CarregaDadosAtividadeExecucao()
        {
            bindingSourceExecucao.DataSource = _execucaoController.BuscarPorAtividadeId(_visualizaExecucaoUserControl.IdSelecionadoAtividade);
            bindingSourceDadosAtividadeExecucao.DataSource = _execucaoController.BuscarDadosAtividade(_visualizaExecucaoUserControl.IdSelecionadoAtividade);
        }
    }
}
