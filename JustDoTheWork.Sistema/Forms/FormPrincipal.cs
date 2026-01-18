using DevExpress.XtraEditors;
using JustDoTheWork.Sistema.ControlPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregaPanel(new HomeUserControl());
        }

        void CarregaPanel(XtraUserControl control)
        {
            panelPrincipal.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(control);
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            var control = panelPrincipal.Controls.OfType<HomeUserControl>().FirstOrDefault();

            if (control != null)
                return;
            else
                CarregaPanel(new HomeUserControl());
        }

        private void RegisterPage_Click(object sender, EventArgs e)
        {
            var control = panelPrincipal.Controls.OfType<RegisterUserControl>().FirstOrDefault();

            if (control != null)
                return;
            else
                CarregaPanel(new RegisterUserControl());
        }

        private void HistoricPage_Click(object sender, EventArgs e)
        {
            var control = panelPrincipal.Controls.OfType<HistoricUserControl>().FirstOrDefault();

            if (control != null)
                return;
            else
                CarregaPanel(new HistoricUserControl());
        }

        private void ReportPage_Click(object sender, EventArgs e)
        {
            var control = panelPrincipal.Controls.OfType<ReportUserControl>().FirstOrDefault();

            if (control != null)
                return;
            else
                CarregaPanel(new ReportUserControl());
        }
    }
}