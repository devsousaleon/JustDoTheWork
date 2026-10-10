using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
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
            CarregaTelaPrincipalExecucao(new VisualizaExecucaoUserControl());
        }

        void CarregaTelaPrincipalExecucao(XtraUserControl xtraUserControl)
        {
            tabTarefas.Controls.Clear();
            tabTarefas.Controls.Add(xtraUserControl);
            xtraUserControl.Dock = DockStyle.Fill;

            tabTarefas.ShowCloseButton = DefaultBoolean.False;
        }

        void CarregaDadosTabControl(XtraTabControl tabControl, XtraUserControl xtraUserControl, string nomeTab)
        {
            foreach (XtraTabPage aba in tabControlPrincipal.TabPages)
            {
                if (string.Equals(aba.Text, nomeTab, StringComparison.OrdinalIgnoreCase))
                {
                    xtraUserControl.Dispose();
                    return;
                }
            }

            XtraTabPage novaAba = tabControl.TabPages.Add();

            novaAba.Controls.Clear();
            xtraUserControl.Dock = DockStyle.Fill;
            novaAba.Controls.Add(xtraUserControl);
            novaAba.Text = nomeTab;
            tabControlPrincipal.SelectedTabPage = novaAba;

            accordionControlMenu.OptionsMinimizing.State = AccordionControlState.Minimized;
        }

        void AbreNovaJanela_Click(object sender, EventArgs e)
        {
            if (sender is not AccordionControlElement elemento)
                return;

            switch (elemento.Tag)
            {
                case "Atividades": CarregaDadosTabControl(tabControlPrincipal, new CadastroAtividadeUserControl(), "Cadastro de Atividades"); return;
                case "ModelosRelatorio": CarregaDadosTabControl(tabControlPrincipal, new CadastroModeloRelatorioUserControl(), "Modelos de Relatório"); return;
                case "Usuarios": CarregaDadosTabControl(tabControlPrincipal, new CadastroUsuarioUserControl(), "Cadastro de Usuários"); return;
                case "RelatorioExecucao": CarregaDadosTabControl(tabControlPrincipal, new HistoricoUserControl(), "Execuções realizadas"); return;
            }
        }

        private void tabControlPrincipal_CloseButtonClick(object sender, EventArgs e)
        {
            if (e is not ClosePageButtonEventArgs argumentos)
                return;

            if (argumentos.Page is not XtraTabPage aba)
                return;

            if (aba == tabTarefas)
                return;

            tabControlPrincipal.TabPages.Remove(aba);
            aba.Dispose();
        }
    }
}
