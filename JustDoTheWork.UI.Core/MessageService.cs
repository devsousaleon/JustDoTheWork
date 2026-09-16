using DevExpress.XtraEditors;

namespace JustDoTheWork.UI.Core.Geral
{
    public static class MessageService
    {
        public static void Erro(string mensagemErro)
        {
            XtraMessageBox.Show
            (
                mensagemErro,
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        public static void Atencao(string mensagemAtencao)
        {
            XtraMessageBox.Show
            (
                mensagemAtencao,
                "Atenção!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        public static void Sucesso(string acaoRealizada)
        {
            XtraMessageBox.Show
            (
                acaoRealizada,
                "Sucesso!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public static void Informacao(string mensagem)
        {
            XtraMessageBox.Show
            (
                mensagem,
                "Informação!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }

        public static DialogResult Pergunta(string pergunta)
        {
            return XtraMessageBox.Show
            (
                pergunta,
                "Dúvida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
        }

        public static void Cancelar(XtraForm form, string mensagem)
        {
            DialogResult result = MessageService.Pergunta(mensagem);

            if (result == DialogResult.Yes)
                form.Close();
        }
    }
}