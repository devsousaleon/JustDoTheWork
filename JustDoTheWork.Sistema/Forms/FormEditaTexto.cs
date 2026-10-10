using DevExpress.XtraEditors;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormEditaTexto : XtraForm
    {
        public string TextoEditado { get; private set; }

        public FormEditaTexto(string textoAtual)
        {
            InitializeComponent();
            TextoEditado = textoAtual;
        }

        void btnSalvarTexto_Click(object sender, EventArgs e)
        {
            TextoEditado = richEditTexto.RtfText;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        void btnFecharEdicaoTexto_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar a edição do texto da atividade? \nAs ações realizadas não serão salvas e serão perdidas!");
        
        void FormEditaTexto_Load(object sender, EventArgs e)
            => richEditTexto.RtfText = TextoEditado ?? "";
    }
}
