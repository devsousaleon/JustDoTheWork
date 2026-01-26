using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class HomeUserControl : XtraUserControl
    {
        private readonly AtividadeController _atividadeController;
        private int IdSelecionado_Pendentes;
        private int IdSelecionado_Executando;
        private int IdSelecionado_Pausado;
        public HomeUserControl()
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
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

        private void dataGridPendentes_SelectionChanged(object sender, EventArgs e)
        {
            IdSelecionado_Pendentes = Convert.ToInt32(dataGridPendentes.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var mensagem = _atividadeController.ExecutarAtividade(IdSelecionado_Pendentes, 3);

            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CarregaGridAtividades();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            var mensagem = _atividadeController.ExecutarAtividade(IdSelecionado_Executando, 4);

            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CarregaGridAtividades();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var mensagem = _atividadeController.ExecutarAtividade(IdSelecionado_Executando, 5);

            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CarregaGridAtividades();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            var mensagem = _atividadeController.ExecutarAtividade(IdSelecionado_Executando, 6);

            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CarregaGridAtividades();
        }

        private void btnExecutarAposPausado_Click(object sender, EventArgs e)
        {
            var mensagem = _atividadeController.ExecutarAtividade(IdSelecionado_Pausado, 3);

            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CarregaGridAtividades();
        }

        private void btnCancelarAposPausado_Click(object sender, EventArgs e)
        {
            var mensagem = _atividadeController.ExecutarAtividade(IdSelecionado_Pausado, 5);

            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CarregaGridAtividades();
        }

        private void dataGridExecutando_SelectionChanged(object sender, EventArgs e)
        {
            IdSelecionado_Executando = Convert.ToInt32(dataGridExecutando.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value);
        }

        private void dataGridPausado_SelectionChanged(object sender, EventArgs e)
        {
            IdSelecionado_Pausado = Convert.ToInt32(dataGridPausado.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value);
        }
    }
}
