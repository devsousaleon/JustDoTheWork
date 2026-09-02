using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using JustDoTheWork.Controller;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Sistema.Composition;
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
            var dadosPendente = _atividadeController.AtualizaGridAtividades(StatusAtividade.Pendente).ToList();
            var dadosExecutando = _atividadeController.AtualizaGridAtividades(StatusAtividade.Executando).ToList();
            var dadosPausado = _atividadeController.AtualizaGridAtividades(StatusAtividade.Pausado).ToList();

            dataGridPendentes.DataSource = dadosPendente;
            dataGridExecutando.DataSource = dadosExecutando;
            dataGridPausado.DataSource = dadosPausado;

            IdSelecionadoAtividade = 0;
            _statusExecucaoSelecionado = 0;
        }

        void btnExecutar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus((int)StatusAtividade.Executando);

        void btnPausar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus((int)StatusAtividade.Pausado);

        void btnVoltaPendente_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus((int)StatusAtividade.Pendente);

        void btnFinalizar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus((int)StatusAtividade.Finalizado);

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
            IdSelecionadoAtividade = Convert.ToInt32(gridView.GetFocusedRowCellValue("AtividadeId"));

            if (IdSelecionadoAtividade <= 0)
                return;

            FormVisualizaAtividadeExecucao _formVisualizaAtividadeExecucao = new(this);
            _formVisualizaAtividadeExecucao.ShowDialog();
        }

        void ExecutaAcaoAlterarStatus(int novoStatus)
        {
            if (IdSelecionadoAtividade <= 0 || _statusExecucaoSelecionado == 0)
            {
                MessageService.Mensagem_Atencao("Selecione uma atividade.");
                return;
            }

            var resultado = _atividadeController.AlterarStatus(IdSelecionadoAtividade, _statusExecucaoSelecionado, novoStatus);

            if (!resultado.Sucesso)
            {
                MessageService.Mensagem_Atencao(resultado.Mensagem);
                return;
            }

            CarregaGridAtividades();
        }

        void InformaIdSelecionadoAtividade(GridView gridView, int status) 
        {
            IdSelecionadoAtividade = Convert.ToInt32(gridView.GetFocusedRowCellValue("AtividadeId"));
            _statusExecucaoSelecionado = status;
        }

        void AtualizaGridTimer(object sender, EventArgs e)
            => CarregaGridAtividades();
    }
}