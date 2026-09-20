using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Forms;
using JustDoTheWork.UI.Core;

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
            bindingSourcePesquisaAtividade.DataSource = new AtividadePesquisaDTO();
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
            => GridCadastroAtividade.DataSource = _atividadeController.PesquisarParaGrid(bindingSourcePesquisaAtividade.Current as AtividadePesquisaDTO).ToList();

        void btnPesquisarAtividade_Click(object sender, EventArgs e)
            => AtualizaGrid();

        void AtualizaComboBoxProjeto()
            => UIMethodsService.AtualizaComboBoxProjeto(_projetoController, comboProjetoPesquisa);

        void AtualizaComboBoxStatus()
            => UIMethodsService.AtualizaComboBoxStatus(_atividadeController, comboStatusPesquisa);

        void btnLimpar_Click(object sender, EventArgs e)
            => bindingSourcePesquisaAtividade.DataSource = new AtividadePesquisaDTO();

        void RepositoryItemButtonEditAtividade_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            IdSelecionado = Convert.ToInt32(gridAtividadesCadastradas.GetFocusedRowCellValue("Id"));
            FormVisualizaCadastro _formVisualizaCadastro = new(this);
            _formVisualizaCadastro.ShowDialog();
        }
    }
}
