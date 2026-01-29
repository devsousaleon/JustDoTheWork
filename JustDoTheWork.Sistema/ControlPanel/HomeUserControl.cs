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

        void dataGridExecutando_SelectionChanged(object sender, EventArgs e)
        {
            IdSelecionadoAtividade = Convert.ToInt32(dataGridExecutando.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value);
            StatusExecucaoSelecionado = 3;
        }

        void dataGridPausado_SelectionChanged(object sender, EventArgs e)
        {
            IdSelecionadoAtividade = Convert.ToInt32(dataGridPausado.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value);
            StatusExecucaoSelecionado = 4;
        }
        void dataGridPendentes_SelectionChanged(object sender, EventArgs e)
        {
            IdSelecionadoAtividade = Convert.ToInt32(dataGridPendentes.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);
            StatusExecucaoSelecionado = 2;
        }

        private void btnVisualizaAtividade_Click(object sender, EventArgs e)
        {
            FormVisualizaAtividadeExecucao Fvae = new FormVisualizaAtividadeExecucao(this);
            Fvae.ShowDialog();
        }

        private void dataGridPendentes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridPendentes.ClearSelection();
            IdSelecionadoAtividade = 0;
            StatusExecucaoSelecionado = 0;
        }

        private void dataGridExecutando_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridExecutando.ClearSelection();
            IdSelecionadoAtividade = 0;
            StatusExecucaoSelecionado = 0;
        }

        private void dataGridPausado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridPausado.ClearSelection();
            IdSelecionadoAtividade = 0;
            StatusExecucaoSelecionado = 0;
        }
    }
}
