using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using JustDoTheWork.Controller;
using JustDoTheWork.Sistema.Forms;
using JustDoTheWork.UI.Core.Geral;
using Timer = System.Windows.Forms.Timer;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class VisualizaExecucaoUserControl : XtraUserControl
    {
        readonly AtividadeController _atividadeController;
        readonly Timer _atualizaTimer;

        int _statusExecucaoSelecionado;

        public int IdSelecionadoAtividade { get; private set; }

        public VisualizaExecucaoUserControl()
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            repositoryButtonActionPendentes.ButtonPressed += RepositoryItemButtonEditPendente_ButtonClick;
            repositoryButtonActionExecucao.ButtonPressed += RepositoryItemButtonEditExecucao_ButtonClick;
            repositoryButtonActionPausado.ButtonPressed += RepositoryItemButtonEditPausado_ButtonClick;
            
            _atualizaTimer = new Timer(components) { Interval = 10000 };
            _atualizaTimer.Tick += AtualizaGridTimer;

        }        

        void HomeUserControl_Load(object sender, EventArgs e)
        { 
            CarregaGridAtividades();
            _atualizaTimer.Start();
        }

        void CarregaGridAtividades()
        {
            var dadosPendente = _atividadeController.AtualizaGridAtividades(2).ToList();
            var dadosExecutando = _atividadeController.AtualizaGridAtividades(3).ToList();
            var dadosPausado = _atividadeController.AtualizaGridAtividades(4).ToList();

            dataGridPendentes.DataSource = dadosPendente;
            dataGridExecutando.DataSource = dadosExecutando;
            dataGridPausado.DataSource = dadosPausado;

            IdSelecionadoAtividade = 0;
            _statusExecucaoSelecionado = 0;
        }

        void btnExecutar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(3,"Inclusao");

        void btnPausar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(4, "Edicao");

        void btnVoltaPendente_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(2, "Edicao");

        void btnFinalizar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(6, "Edicao");

        void gridExecutando_RowClick(object sender, RowClickEventArgs e)
            => InformaIdSelecionadoAtividade(gridExecutando, 3);

        void gridPausado_RowClick(object sender, RowClickEventArgs e)
            => InformaIdSelecionadoAtividade(gridPausado, 4);

        void gridPendentes_RowClick(object sender, RowClickEventArgs e)
            => InformaIdSelecionadoAtividade(gridPendentes, 2);

        void RepositoryItemButtonEditPendente_ButtonClick(object sender, ButtonPressedEventArgs e)
            => InstanciaFormPorIdSelecionado(gridPendentes); 
        
        void RepositoryItemButtonEditExecucao_ButtonClick(object sender, ButtonPressedEventArgs e)
            => InstanciaFormPorIdSelecionado(gridExecutando); 
        
        void RepositoryItemButtonEditPausado_ButtonClick(object sender, ButtonPressedEventArgs e)
            => InstanciaFormPorIdSelecionado(gridPausado);        

        void InstanciaFormPorIdSelecionado(GridView gridView)
        {
            IdSelecionadoAtividade = Convert.ToInt32(gridView.GetFocusedRowCellValue("Id"));

            if (IdSelecionadoAtividade <= 0)
                return;

            FormVisualizaAtividadeExecucao _formVisualizaAtividadeExecucao = new(this);
            _formVisualizaAtividadeExecucao.ShowDialog();
        }

        void ExecutaAcaoAlterarStatus(int novoStatus, string acaoExecutada)
        {
            if (IdSelecionadoAtividade <= 0 || _statusExecucaoSelecionado == 0)
            {
                MessageService.Atencao("Selecione uma atividade.");
                return;
            }

            var mensagemRetornoAlteracaoStatus = _atividadeController.AlterarStatus(IdSelecionadoAtividade, _statusExecucaoSelecionado, novoStatus, acaoExecutada);

            if (!string.IsNullOrWhiteSpace(mensagemRetornoAlteracaoStatus))
            {
                MessageService.Atencao(mensagemRetornoAlteracaoStatus);
                return;
            }

            CarregaGridAtividades();
        }

        void InformaIdSelecionadoAtividade(GridView gridView, int status) 
        {
            IdSelecionadoAtividade = Convert.ToInt32(gridView.GetFocusedRowCellValue("Id"));
            _statusExecucaoSelecionado = status;
        }

        void AtualizaGridTimer(object sender, EventArgs e)
            => CarregaGridAtividades();
    }        
}
