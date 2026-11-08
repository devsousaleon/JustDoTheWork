using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using JustDoTheWork.Sistema.ControlPanel;
using JustDoTheWork.Controller;
using JustDoTheWork.Entity;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormPrincipal : XtraForm
    {
        private readonly int? _usuarioId;

        public FormPrincipal() : this(null)
        {
        }

        public FormPrincipal(int? usuarioId)
        {
            InitializeComponent();
            _usuarioId = usuarioId;
        }

        void FormPrincipal_Load(object sender, EventArgs e)
        {
            var usuario = CompositionRoot.UsuarioAtual ?? throw new InvalidOperationException("É necessário entrar no sistema com um usuário cadastrado.");
            Text = $"JustDoTheWork — {usuario.Nome} ({usuario.TipoUsuario})";
            accordionElementUsuarios.Visible = usuario.EhTechLead;
            var podeAdministrar = usuario.EhTechLead || string.Equals(usuario.TipoUsuario, FluxoAtividade.Historiador, StringComparison.OrdinalIgnoreCase);
            accordionElementCadastro.Visible = podeAdministrar;
            accordionElementAtividades.Visible = podeAdministrar;
            accordionElementModeloRelatorio.Visible = podeAdministrar;
            accordionElementRelatorioExecucao.Text = podeAdministrar ? "Relatório de Execuções" : "Minhas execuções";
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
            var usuario = CompositionRoot.UsuarioAtual;
            var podeAdministrar = usuario?.EhTechLead == true || string.Equals(usuario?.TipoUsuario, FluxoAtividade.Historiador, StringComparison.OrdinalIgnoreCase);
            if ((elemento.Tag is "Atividades" or "ModelosRelatorio" && !podeAdministrar) || (elemento.Tag is "Usuarios" && usuario?.EhTechLead != true))
                return;

            switch (elemento.Tag)
            {
                case "Atividades": CarregaDadosTabControl(tabControlPrincipal, new CadastroAtividadeUserControl(), "Cadastro de Atividades"); return;
                case "ModelosRelatorio": CarregaDadosTabControl(tabControlPrincipal, new CadastroModeloRelatorioUserControl(), "Modelos de Relatório"); return;
                case "Usuarios": CarregaDadosTabControl(tabControlPrincipal, new CadastroUsuarioUserControl(), "Cadastro de Usuários"); return;
                case "RelatorioExecucao": CarregaDadosTabControl(tabControlPrincipal, new HistoricoUserControl(_usuarioId), "Execuções realizadas"); return;
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
