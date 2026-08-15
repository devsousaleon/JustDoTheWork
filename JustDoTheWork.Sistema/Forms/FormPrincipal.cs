using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using JustDoTheWork.Sistema.ControlPanel;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormPrincipal : XtraForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregaDadosTabControl(tabTarefas, new VisualizaExecucaoUserControl());
            CarregaDadosTabControl(tabCadastro, new VisualizaAtividadesUserControl());
            CarregaDadosTabControl(tabHistorico, new HistoricoUserControl());
            CarregaDadosTabControl(tabCadastroModeloRelatorio, new CadastroModeloRelatorioUserControl());
        }

        void CarregaDadosTabControl(XtraTabPage aba, XtraUserControl control)
        {
            aba.Controls.Clear();
            control.Dock = DockStyle.Fill;
            aba.Controls.Add(control);
        }
    }
}