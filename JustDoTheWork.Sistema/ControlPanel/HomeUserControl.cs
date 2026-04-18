using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.Sistema.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class HomeUserControl : XtraUserControl
    {
        private readonly AtividadeController _atividadeController;
        private readonly ExecucaoController _execucaoController;

        private int StatusExecucaoSelecionado;
        public int IdSelecionadoAtividade { get; private set; }

        //futuramente alterar a forma como está o código abaixo dos botões.
        //Fazer um método central que realize todas as ações e apenas chamar no eventclick do botão 
        // MODIFICAR PARA QUE FIQUE APENAS UM MÉTODO PARA TUDO QUE É IGUAL

        public HomeUserControl()
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _execucaoController = CompositionRoot.CriarExecucaoController();
        }
        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            CarregaGridAtividades();
        }

        void CarregaGridAtividades()
        {
            var dadosPendente = _atividadeController.AtualizaGridAtividades(2).ToList();
            var dadosExecutando = _atividadeController.AtualizaGridAtividades(3).ToList();
            var dadosPausado = _atividadeController.AtualizaGridAtividades(4).ToList();

            dataGridPendentes.DataSource = dadosPendente;
            dataGridExecutando.DataSource = dadosExecutando;
            dataGridPausado.DataSource = dadosPausado;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (IdSelecionadoAtividade <= 0 && StatusExecucaoSelecionado == 0)
                return;

            var mensagemAtividade = _atividadeController.AlterarStatus(IdSelecionadoAtividade, StatusExecucaoSelecionado, 3);

            if (!string.IsNullOrWhiteSpace(mensagemAtividade))
            {
                XtraMessageBox.Show(mensagemAtividade, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mensagemExecucao = _execucaoController.Inclusao(IdSelecionadoAtividade);

            if (!string.IsNullOrWhiteSpace(mensagemExecucao))
            {
                XtraMessageBox.Show(mensagemExecucao, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CarregaGridAtividades();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (IdSelecionadoAtividade <= 0 && StatusExecucaoSelecionado == 0)
                return;

            var mensagemPausaAtividade = _atividadeController.AlterarStatus(IdSelecionadoAtividade, StatusExecucaoSelecionado, 4);

            if (!string.IsNullOrWhiteSpace(mensagemPausaAtividade))
            {
                XtraMessageBox.Show(mensagemPausaAtividade, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mensagemFinalizaExecucao = _execucaoController.FinalizaExecucao(IdSelecionadoAtividade);

            if (!string.IsNullOrWhiteSpace(mensagemFinalizaExecucao))
            {
                XtraMessageBox.Show(mensagemFinalizaExecucao, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarregaGridAtividades();
        }

        private void btnVoltaPendente_Click(object sender, EventArgs e)
        {
            if (IdSelecionadoAtividade <= 0 && StatusExecucaoSelecionado == 0)
                return;

            var mensagem = _atividadeController.AlterarStatus(IdSelecionadoAtividade, StatusExecucaoSelecionado, 2);

            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mensagemFinalizaExecucao = _execucaoController.FinalizaExecucao(IdSelecionadoAtividade);

            if (!string.IsNullOrWhiteSpace(mensagemFinalizaExecucao))
            {
                XtraMessageBox.Show(mensagemFinalizaExecucao, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarregaGridAtividades();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (IdSelecionadoAtividade <= 0 && StatusExecucaoSelecionado == 0)
                return;

            var mensagem = _atividadeController.AlterarStatus(IdSelecionadoAtividade, StatusExecucaoSelecionado, 6);

            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mensagemFinalizaExecucao = _execucaoController.FinalizaExecucao(IdSelecionadoAtividade);

            if (!string.IsNullOrWhiteSpace(mensagemFinalizaExecucao))
            {
                XtraMessageBox.Show(mensagemFinalizaExecucao, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarregaGridAtividades();
        }

        private void btnVisualizaAtividade_Click(object sender, EventArgs e)
        {
            if (IdSelecionadoAtividade <= 0)
                return;
            FormVisualizaAtividadeExecucao Fvae = new FormVisualizaAtividadeExecucao(this);
            Fvae.ShowDialog();
        }

        private void gridPendentes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            IdSelecionadoAtividade = Convert.ToInt32(gridPendentes.GetFocusedRowCellValue("AtividadeId"));
            StatusExecucaoSelecionado = 2;

            if (IdSelecionadoAtividade <= 0)
                return;
            FormVisualizaAtividadeExecucao Fvae = new FormVisualizaAtividadeExecucao(this);
            Fvae.ShowDialog();
        }
        private void gridExecutando_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            IdSelecionadoAtividade = Convert.ToInt32(gridExecutando.GetFocusedRowCellValue("AtividadeId"));
            StatusExecucaoSelecionado = 3;

            if (IdSelecionadoAtividade <= 0)
                return;
            FormVisualizaAtividadeExecucao Fvae = new FormVisualizaAtividadeExecucao(this);
            Fvae.ShowDialog();
        }

        private void gridPausado_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            IdSelecionadoAtividade = Convert.ToInt32(gridPausado.GetFocusedRowCellValue("AtividadeId"));
            StatusExecucaoSelecionado = 4;

            if (IdSelecionadoAtividade <= 0)
                return;
            FormVisualizaAtividadeExecucao Fvae = new FormVisualizaAtividadeExecucao(this);
            Fvae.ShowDialog();
        }
    }
}
