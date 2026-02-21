using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormEditaTextoAtividade : XtraForm
    {
        public string NovoTextoDescricaoAtividade { get; private set; }

        public FormEditaTextoAtividade(string TextoAtualDescricaoAtividade)
        {
            InitializeComponent();
            NovoTextoDescricaoAtividade = TextoAtualDescricaoAtividade;
        }

        private void btnSalvarEdit_Click(object sender, EventArgs e)
        {
            NovoTextoDescricaoAtividade = txtEditorAtividade.RtfText;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fechar a edição do texto da atividade? \n" +
                "As ações realizadas não serão salvas e serão perdidas!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                this.Close();
        }
        private void FormEditaTextoAtividade_Load(object sender, EventArgs e)
        {
            txtEditorAtividade.RtfText = NovoTextoDescricaoAtividade ?? "";
        }
    }
}