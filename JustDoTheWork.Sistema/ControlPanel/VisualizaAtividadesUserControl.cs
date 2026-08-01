using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.Sistema.Forms;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class VisualizaAtividadesUserControl : XtraUserControl
    {
        public int IdSelecionado { get; private set; }
        private readonly AtividadeController _atividadeController;
        private readonly ProjetoController _projetoController;

        public VisualizaAtividadesUserControl()
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _projetoController = CompositionRoot.CriarProjetoController();
            repositoryItemButtonAtividades.ButtonPressed += RepositoryItemButtonEditAtividade_ButtonClick;
        }

        void RegisterUserControl_Load(object sender, EventArgs e)
        {
            AtualizaComboBoxProjeto();
            AtualizaComboBoxStatus();
        }

        void btnIncluirAtividade_Click(object sender, EventArgs e)
        {
            FormCadastroAtividade _formCadastro = new();
            _formCadastro.ShowDialog();
        }

        public void AtualizaGrid()
        {
            var filtro = new AtividadePesquisaDTO
            {
                Nome = txtNomeAtividade.Text,
                Status = comboStatusPesquisa.EditValue != null ? (int?)comboStatusPesquisa.EditValue : null,
                ProjetoId = comboProjetoPesquisa.EditValue != null ? (int?)comboProjetoPesquisa.EditValue : null,
                DataCriacao = dataCriacaoPesquisa.EditValue != null ? (DateTime?)dataCriacaoPesquisa.DateTime : null
            };

            var dadosGrid = _atividadeController.PesquisarParaGrid(filtro).ToList();

            GridCadastroAtividade.DataSource = dadosGrid;
        }

        void btnPesquisarAtividade_Click(object sender, EventArgs e)
            => AtualizaGrid();

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

        void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeAtividade.Text = "";
            comboProjetoPesquisa.EditValue = null;
            comboStatusPesquisa.EditValue = null;
            dataCriacaoPesquisa.EditValue = null;
        }

        void RepositoryItemButtonEditAtividade_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            IdSelecionado = Convert.ToInt32(gridAtividadesCadastradas.GetFocusedRowCellValue("Id"));
            FormVisualizaCadastro _formVisualizaCadastro = new(this);
            _formVisualizaCadastro.ShowDialog();
        }
    }
}