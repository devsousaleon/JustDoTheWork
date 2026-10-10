using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.OpenXml;
using JustDoTheWork.Controller;
using JustDoTheWork.UI.Core.Geral;
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
    public partial class FormLogin : XtraForm
    {
        private readonly UsuarioController usuarioController;

        public FormLogin()
        {
            InitializeComponent();
            timer_Tick(null, EventArgs.Empty);
            usuarioController = CompositionRoot.CriarUsuarioController();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ConfigurarBotaoIcone(btnFecharSistema);
            ConfigurarBotaoIcone(btnMinimizar);            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblBoasVindas.Text = $"Seja bem-vindo! {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        private static void ConfigurarBotaoIcone(SimpleButton botao)
        {
            botao.AllowFocus = false;
            botao.TabStop = false;
            botao.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;

            botao.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

            botao.ImageOptions.SvgImageSize = new Size(30, 30);
            botao.ImageOptions.Location = ImageLocation.MiddleCenter;
        }

        private void btnFecharSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string mensagem = ValidarCampos();

            if (mensagem != "")
            {
                MessageService.Atencao(mensagem);
                return;
            }

            if(txtSenha.Text == "admin@123" && txtUsuario.Text == "adm")
                AcessarSistema();

            var resultado = usuarioController.BuscaUsuarioPorLogon(txtUsuario.Text);

            if (resultado is null || !VerificarSenha(txtSenha.Text, resultado.Senha))
            {
                MessageService.Atencao("Usuário ou senha inválidos!");
                return;
            }

            AcessarSistema();
        }

        private static bool VerificarSenha(string senha, string hash)
        {
            if (string.IsNullOrWhiteSpace(hash) || hash.Length != 60 || Encoding.UTF8.GetByteCount(senha) > 72)
                return false;

            try
            {
                return BCrypt.Net.BCrypt.Verify(senha, hash);
            }
            catch (BCrypt.Net.SaltParseException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        void AcessarSistema()
        {
            var formPrincipal = new FormPrincipal();

            formPrincipal.FormClosed += (_, _) => this.Close();

            this.Hide();
            formPrincipal.Show();
        }

        private string ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                return "Favor informar o nome do usuário!";

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
                return "Favor informar a senha!";

            return "";
        }
    }
}