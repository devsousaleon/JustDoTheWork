using DevExpress.XtraEditors.Controls;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.Sistema.Forms;
using JustDoTheWork.UI.Core;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class CadastroModeloRelatorioUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly TipoModeloController _tipoModeloController;
        private readonly ModeloRelatorioController _modeloRelatorioController;
        public int IdSelecionado { get; private set; }

        public CadastroModeloRelatorioUserControl()
        {
            InitializeComponent();
            _tipoModeloController = CompositionRoot.CriarTipoModeloController();
            _modeloRelatorioController = CompositionRoot.CriarModeloRelatorioController();
            repositoryItemButtonAction.ButtonPressed += RepositoryItemButtonEditAction_ButtonClick;
        }

        void CadastroModeloRelatorioUserControl_Load(object sender, EventArgs e)
            => BuscaTipoModelo();

        void btnIncluirModelo_Click(object sender, EventArgs e)
        {
            FormCadastroModeloRelatorio formCadastroModeloRelatorio = new FormCadastroModeloRelatorio();
            formCadastroModeloRelatorio.ShowDialog();
        }

        void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricaoModelo.Text = "";
            comboTipoModelo.EditValue = null;
        }

        void btnPesquisarModelo_Click(object sender, EventArgs e)
            => AtualizaGrid();

        public void AtualizaGrid()
        {
            var filtro = new FiltroPesquisaModeloRelatorioDTO
            {
                TipoModelo = (int?)comboTipoModelo.EditValue,
                DescricaoModelo = txtDescricaoModelo.Text
            };

            var busca = _modeloRelatorioController.PesquisaModeloRelatorio(filtro).ToList();

            gridControlModeloRelatorio.DataSource = busca;
        }

        void BuscaTipoModelo()
            => UIMethodsService.AtualizaComboBoxTipoModelo(_tipoModeloController, comboTipoModelo);

        void RepositoryItemButtonEditAction_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            IdSelecionado = Convert.ToInt32(gridModeloRelatorio.GetFocusedRowCellValue("Id"));
            FormVisualizaModeloRelatorio _formVisualizaModeloRelatorio = new(this);
            _formVisualizaModeloRelatorio.ShowDialog();
        }
    }
}