using DevExpress.XtraEditors.Controls;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
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
            DesignGrid.Configurar(gridModeloRelatorio, (colId, 70), (colDescricao, 480), (colTipoModelo, 300), (colAtivo, 80));
            _tipoModeloController = CompositionRoot.CriarTipoModeloController();
            _modeloRelatorioController = CompositionRoot.CriarModeloRelatorioController();
            repositoryButtonAcao.ButtonPressed += repositoryButtonAcao_ButtonPressed;
        }

        void CadastroModeloRelatorioUserControl_Load(object sender, EventArgs e)
            => AtualizaComboBoxTipoModelo();

        void btnIncluirModeloRelatorio_Click(object sender, EventArgs e)
        {
            FormCadastroModeloRelatorio formCadastroModeloRelatorio = new FormCadastroModeloRelatorio();
            formCadastroModeloRelatorio.ShowDialog();
        }

        void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricaoModelo.Text = "";
            comboTipoModelo.EditValue = null;
        }

        void btnPesquisarModeloRelatorio_Click(object sender, EventArgs e)
            => AtualizaGrid();

        public void AtualizaGrid()
        {
            var filtro = new FiltroPesquisaModeloRelatorioDTO
            {
                TipoModelo = (int?)comboTipoModelo.EditValue,
                DescricaoModelo = txtDescricaoModelo.Text
            };

            var busca = _modeloRelatorioController.Pesquisar(filtro).ToList();

            gridControlModeloRelatorio.DataSource = busca;
        }

        void AtualizaComboBoxTipoModelo()
            => UIMethodsService.AtualizaComboBoxTipoModelo(_tipoModeloController, comboTipoModelo);

        void repositoryButtonAcao_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            IdSelecionado = Convert.ToInt32(gridModeloRelatorio.GetFocusedRowCellValue("Id"));
            FormVisualizaModeloRelatorio formVisualizaModeloRelatorio = new(this);
            formVisualizaModeloRelatorio.ShowDialog();
        }
    }
}
