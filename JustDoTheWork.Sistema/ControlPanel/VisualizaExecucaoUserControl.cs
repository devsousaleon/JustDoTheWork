using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using JustDoTheWork.Controller;
using JustDoTheWork.Sistema.Forms;
using JustDoTheWork.UI.Core;
using JustDoTheWork.UI.Core.Geral;
using Timer = System.Windows.Forms.Timer;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class VisualizaExecucaoUserControl : XtraUserControl
    {
        readonly AtividadeController _atividadeController;
        readonly Timer timerAtualizaGrid;

        int _statusExecucaoSelecionado;

        public int IdSelecionadoAtividade { get; private set; }

        public VisualizaExecucaoUserControl()
        {
            InitializeComponent();
            DesignGrid.Configurar(gridPendentes, (colAtividadeId, 65), (colNomeAtividade, 250), (colNomeProjeto, 180));
            DesignGrid.Configurar(gridExecutando, (colAtividadeIdExecutando, 65), (colNomeAtividadeExecutando, 350), (colNomeProjetoExecutando, 220));
            DesignGrid.Configurar(gridPausado, (colAtividadeIdPausado, 65), (colNomeAtividadePausado, 350), (colNomeProjetoPausado, 220));
            _atividadeController = CompositionRoot.CriarAtividadeController();
            repositoryButtonAcaoPendente.ButtonPressed += repositoryButtonAcaoPendente_ButtonPressed;
            repositoryButtonAcaoExecutando.ButtonPressed += repositoryButtonAcaoExecutando_ButtonPressed;
            repositoryButtonAcaoPausado.ButtonPressed += repositoryButtonAcaoPausado_ButtonPressed;
            
            timerAtualizaGrid = new Timer(components) { Interval = 10000 };
            timerAtualizaGrid.Tick += timerAtualizaGrid_Tick;

        }        

        void VisualizaExecucaoUserControl_Load(object sender, EventArgs e)
        { 
            AtualizaGrid();
            timerAtualizaGrid.Start();
        }

        void AtualizaGrid()
        {
            var dadosPendente = _atividadeController.PesquisarPorStatus(2).ToList();
            var dadosExecutando = _atividadeController.PesquisarPorStatus(3).ToList();
            var dadosPausado = _atividadeController.PesquisarPorStatus(4).ToList();

            gridControlPendentes.DataSource = dadosPendente;
            gridControlExecutando.DataSource = dadosExecutando;
            gridControlPausado.DataSource = dadosPausado;

            IdSelecionadoAtividade = 0;
            _statusExecucaoSelecionado = 0;
        }

        void btnExecutar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(3,"Inclusao");

        void btnPausar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(4, "Edicao");

        void btnVoltarPendente_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(2, "Edicao");

        void btnFinalizar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(6, "Edicao");

        void gridExecutando_RowClick(object sender, RowClickEventArgs e)
            => InformaIdSelecionadoAtividade(gridExecutando, 3);

        void gridPausado_RowClick(object sender, RowClickEventArgs e)
            => InformaIdSelecionadoAtividade(gridPausado, 4);

        void gridPendentes_RowClick(object sender, RowClickEventArgs e)
            => InformaIdSelecionadoAtividade(gridPendentes, 2);

        void repositoryButtonAcaoPendente_ButtonPressed(object sender, ButtonPressedEventArgs e)
            => InstanciaFormPorIdSelecionado(gridPendentes); 
        
        void repositoryButtonAcaoExecutando_ButtonPressed(object sender, ButtonPressedEventArgs e)
            => InstanciaFormPorIdSelecionado(gridExecutando); 
        
        void repositoryButtonAcaoPausado_ButtonPressed(object sender, ButtonPressedEventArgs e)
            => InstanciaFormPorIdSelecionado(gridPausado);        

        void InstanciaFormPorIdSelecionado(GridView gridView)
        {
            IdSelecionadoAtividade = Convert.ToInt32(gridView.GetFocusedRowCellValue("Id"));

            if (IdSelecionadoAtividade <= 0)
                return;

            FormVisualizaAtividadeExecucao formVisualizaAtividadeExecucao = new(this);
            formVisualizaAtividadeExecucao.ShowDialog();
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

            AtualizaGrid();
        }

        void InformaIdSelecionadoAtividade(GridView gridView, int status) 
        {
            IdSelecionadoAtividade = Convert.ToInt32(gridView.GetFocusedRowCellValue("Id"));
            _statusExecucaoSelecionado = status;
        }

        void timerAtualizaGrid_Tick(object sender, EventArgs e)
            => AtualizaGrid();
    }        
}
