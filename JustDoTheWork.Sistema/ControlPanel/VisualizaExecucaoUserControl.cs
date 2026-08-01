using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using JustDoTheWork.Controller;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.Sistema.Forms;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class VisualizaExecucaoUserControl : XtraUserControl
    {
        private readonly AtividadeController _atividadeController;
        private readonly ExecucaoController _execucaoController;

        int _statusExecucaoSelecionado;
        public int IdSelecionadoAtividade { get; private set; }

        enum TipoExecucao { Inclusao, Edicao }

        public VisualizaExecucaoUserControl()
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _execucaoController = CompositionRoot.CriarExecucaoController();
            repositoryButtonActionPendentes.ButtonPressed += RepositoryItemButtonEditPendente_ButtonClick;
            repositoryButtonActionExecucao.ButtonPressed += RepositoryItemButtonEditExecucao_ButtonClick;
            repositoryButtonActionPausado.ButtonPressed += RepositoryItemButtonEditPausado_ButtonClick;
        }

        void HomeUserControl_Load(object sender, EventArgs e)
            => CarregaGridAtividades();

        void CarregaGridAtividades()
        {
            var dadosPendente = _atividadeController.AtualizaGridAtividades(2).ToList();
            var dadosExecutando = _atividadeController.AtualizaGridAtividades(3).ToList();
            var dadosPausado = _atividadeController.AtualizaGridAtividades(4).ToList();

            dataGridPendentes.DataSource = dadosPendente;
            dataGridExecutando.DataSource = dadosExecutando;
            dataGridPausado.DataSource = dadosPausado;
        }

        void btnExecutar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(3, TipoExecucao.Inclusao);

        void btnPausar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(4, TipoExecucao.Edicao);

        void btnVoltaPendente_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(2, TipoExecucao.Edicao);

        void btnFinalizar_Click(object sender, EventArgs e)
            => ExecutaAcaoAlterarStatus(6, TipoExecucao.Edicao);

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

        void ExecutaAcaoAlterarStatus(int novoStatus, TipoExecucao acaoExecutada)
        {
            if (IdSelecionadoAtividade <= 0 || _statusExecucaoSelecionado == 0)
                return;

            var mensagemRetornoAlteracaoStatus = _atividadeController.AlterarStatus(IdSelecionadoAtividade, _statusExecucaoSelecionado, novoStatus);

            if (!string.IsNullOrWhiteSpace(mensagemRetornoAlteracaoStatus))
            {
                MessageService.Mensagem_Atencao(mensagemRetornoAlteracaoStatus);
                return;
            }

            if (acaoExecutada == TipoExecucao.Edicao)
            {
                var mensagemRetornoFinalizaExecucao = _execucaoController.FinalizaExecucao(IdSelecionadoAtividade);

                if (!string.IsNullOrWhiteSpace(mensagemRetornoFinalizaExecucao))
                {
                    MessageService.Mensagem_Erro(mensagemRetornoFinalizaExecucao);
                    return;
                }
            }
            else if (acaoExecutada == TipoExecucao.Inclusao)
            {
                var mensagemRetornoExecucao = _execucaoController.Inclusao(IdSelecionadoAtividade);

                if (!string.IsNullOrWhiteSpace(mensagemRetornoExecucao))
                {
                    MessageService.Mensagem_Erro(mensagemRetornoExecucao);
                    return;
                }
            }
            CarregaGridAtividades();
        }

        void InformaIdSelecionadoAtividade(GridView gridView, int status) 
        {
            IdSelecionadoAtividade = Convert.ToInt32(gridView.GetFocusedRowCellValue("AtividadeId"));
            _statusExecucaoSelecionado = status;
        }
    }
}