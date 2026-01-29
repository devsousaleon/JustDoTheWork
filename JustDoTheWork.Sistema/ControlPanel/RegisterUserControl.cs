using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.Sistema.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class RegisterUserControl : XtraUserControl
    {
        public bool Inclusao { get; private set; }

        public int IdSelecionado { get; private set; }
        private readonly AtividadeController _atividadeController;
        private readonly ProjetoController _projetoController;

        public RegisterUserControl()
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _projetoController = CompositionRoot.CriarProjetoController();
        }
        private void RegisterUserControl_Load(object sender, EventArgs e)
        {
            AtualizaComboBoxProjeto();
            AtualizaComboBoxStatus();
        }

        private void btnIncluirAtividade_Click(object sender, EventArgs e)
        {
            Inclusao = true;
            FormCadastro fr = new FormCadastro(this);
            fr.ShowDialog();
        }

        public void AtualizaGrid()
        {
            var filtro = new AtividadePesquisaDTO
            {
                Nome = txtNomeAtividade.Text,

                Status = comboStatusPesquisa.EditValue != null
                    ? (int?)comboStatusPesquisa.EditValue
                    : null,

                ProjetoId = comboProjetoPesquisa.EditValue != null
                    ? (int?)comboProjetoPesquisa.EditValue
                    : null,

                DataCriacao = dataCriacaoPesquisa.EditValue != null
                    ? (DateTime?)dataCriacaoPesquisa.DateTime
                    : null
            };

            var dadosGrid = _atividadeController
                .PesquisarParaGrid(filtro)
                .ToList();

            GridCadastroAtividade.DataSource = dadosGrid;
        }

        private void btnPesquisarAtividade_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        public void AtualizaComboBoxProjeto()
        {
            var dados = _projetoController.PesquisarParaCombo().ToList();

            if (dados == null)
                return;

            comboProjetoPesquisa.Properties.DataSource = dados;
            comboProjetoPesquisa.Properties.DisplayMember = "Nome";
            comboProjetoPesquisa.Properties.ValueMember = "Id";
            comboProjetoPesquisa.Properties.NullText = "Selecione um projeto";
        }

        void AtualizaComboBoxStatus()
        {
            comboStatusPesquisa.Properties.DataSource = _atividadeController.ObterStatusAtividade();

            comboStatusPesquisa.Properties.DisplayMember = "Status";
            comboStatusPesquisa.Properties.ValueMember = "Id";
            comboStatusPesquisa.Properties.NullText = "Selecione uma opção";
        }

        private void GridCadastroAtividade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {    
                FormVisualizaCadastro fvc = new FormVisualizaCadastro(this);
                fvc.ShowDialog();
            }
        }

        private void GridCadastroAtividade_SelectionChanged(object sender, EventArgs e)
        {
            IdSelecionado = Convert.ToInt32(GridCadastroAtividade.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
        }
    }
}
