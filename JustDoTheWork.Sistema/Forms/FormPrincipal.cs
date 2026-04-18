using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using JustDoTheWork.Sistema.ControlPanel;
using System;
using System.Windows.Forms;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormPrincipal : XtraForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregaDadosTabControl(tabTarefas, new HomeUserControl());
            CarregaDadosTabControl(tabCadastro, new RegisterUserControl());
        }

        void CarregaDadosTabControl(XtraTabPage aba, XtraUserControl control)
        {
            aba.Controls.Clear();
            control.Dock = DockStyle.Fill;
            aba.Controls.Add(control);
        }
    }
}