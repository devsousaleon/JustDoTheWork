using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.Sistema.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class RegisterUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public bool Inclusao { get; private set; }

        public RegisterUserControl()
        {
            InitializeComponent();
        }

        private void btnIncluirAtividade_Click(object sender, EventArgs e)
        {
            Inclusao = true;
            FormCadastro fr = new FormCadastro(this);
            fr.ShowDialog();
        }
    }
}
