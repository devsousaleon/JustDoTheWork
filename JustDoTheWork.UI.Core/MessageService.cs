using DevExpress.XtraEditors;

namespace JustDoTheWork.UI.Core.Geral
{
    public static class MessageService
    {
        public static void Mensagem_Erro(string mensagemErro)
        {
            XtraMessageBox.Show
            (
                mensagemErro,
                "Identificado erro em execução",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        public static void Mensagem_Atencao(string mensagemAtencao)
        {
            XtraMessageBox.Show
            (
                mensagemAtencao,
                "Atenção a ação executada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        public static void Mensagem_Sucesso(string acaoRealizada)
        {
            XtraMessageBox.Show
            (
                acaoRealizada,
                "Sucesso em execução",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public static DialogResult Mensagem_Pergunta(string pergunta)
        {
            return XtraMessageBox.Show
            (
                pergunta,
                "Dúvida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
        }

        public static void Acao_FecharForm_CancelarExecucao(XtraForm form, string mensagem)
        {
            DialogResult result = MessageService.Mensagem_Pergunta(mensagem);

            if (result == DialogResult.Yes)
                form.Close();
        }
    }
}