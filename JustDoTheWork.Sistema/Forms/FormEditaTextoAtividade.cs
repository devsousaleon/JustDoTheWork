using DevExpress.XtraEditors;
using JustDoTheWork.UI.Core.Geral;

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
            MessageService.Acao_FecharForm_CancelarExecucao(this, "Deseja realmente fechar a edição do texto da atividade? \nAs ações realizadas não serão salvas e serão perdidas!");
        }
        private void FormEditaTextoAtividade_Load(object sender, EventArgs e)
        {
            txtEditorAtividade.RtfText = NovoTextoDescricaoAtividade ?? "";
        }
    }
}