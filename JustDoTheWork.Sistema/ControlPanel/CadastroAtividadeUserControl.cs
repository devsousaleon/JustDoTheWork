using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Forms;
using JustDoTheWork.UI.Core;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class CadastroAtividadeUserControl : XtraUserControl
    {
        public int IdSelecionado { get; private set; }
        private readonly AtividadeController _atividadeController;
        private readonly ProjetoController _projetoController;

        public CadastroAtividadeUserControl()
        {
            InitializeComponent();
            DesignGrid.Configurar(gridAtividade, (colId, 70), (colAtividade, 520), (colProjeto, 350));
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _projetoController = CompositionRoot.CriarProjetoController();
            repositoryButtonAcao.ButtonPressed += repositoryButtonAcao_ButtonPressed;
            bindingSourceFiltroPesquisaAtividade.DataSource = new FiltroPesquisaAtividadeDTO();
        }

        void CadastroAtividadeUserControl_Load(object sender, EventArgs e)
        {
            AtualizaComboBoxProjeto();
            AtualizaComboBoxStatus();
        }

        void btnIncluirAtividade_Click(object sender, EventArgs e)
        {
            FormCadastroAtividade formCadastroAtividade = new();
            formCadastroAtividade.ShowDialog();
        }

        public void AtualizaGrid()
            => gridControlAtividade.DataSource = _atividadeController.Pesquisar(bindingSourceFiltroPesquisaAtividade.Current as FiltroPesquisaAtividadeDTO).ToList();

        void btnPesquisarAtividade_Click(object sender, EventArgs e)
            => AtualizaGrid();

        void AtualizaComboBoxProjeto()
            => UIMethodsService.AtualizaComboBoxProjeto(_projetoController, comboProjetoPesquisa);

        void AtualizaComboBoxStatus()
            => UIMethodsService.AtualizaComboBoxStatus(_atividadeController, comboStatusPesquisa);

        void btnLimpar_Click(object sender, EventArgs e)
            => bindingSourceFiltroPesquisaAtividade.DataSource = new FiltroPesquisaAtividadeDTO();

        void repositoryButtonAcao_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            IdSelecionado = Convert.ToInt32(gridAtividade.GetFocusedRowCellValue("Id"));
            FormVisualizaAtividade formVisualizaAtividade = new(this);
            formVisualizaAtividade.ShowDialog();
        }
    }
}
