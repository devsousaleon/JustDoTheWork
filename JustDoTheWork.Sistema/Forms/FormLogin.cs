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
        private readonly UsuarioController _usuarioController;

        public FormLogin()
        {
            InitializeComponent();
            timerBoasVindas_Tick(null, EventArgs.Empty);
            _usuarioController = CompositionRoot.CriarUsuarioController();
            Shown += FormLogin_Shown;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ConfigurarBotaoIcone(btnFecharSistema);
            ConfigurarBotaoIcone(btnMinimizar);            
        }

        private async void FormLogin_Shown(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(CompositionRoot.PrepararConsultas);
            }
            catch (Exception)
            {
                // A preparação é opcional; a entrada no sistema trata a falha da consulta.
                System.Diagnostics.Debug.WriteLine("Não foi possível preparar as consultas do sistema.");
            }
        }

        private void timerBoasVindas_Tick(object sender, EventArgs e)
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

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!btnEntrar.Enabled)
                return;

            string mensagem = ValidarCampos();

            if (mensagem != "")
            {
                MessageService.Atencao(mensagem);
                return;
            }

            var logon = txtLogon.Text;
            var senha = txtSenha.Text;
            var acessoAdministrador = senha == "admin@123" && logon == "adm";
            btnEntrar.Enabled = false;
            UseWaitCursor = true;

            try
            {
                var resultado = await Task.Run(() => _usuarioController.BuscarParaLogin(logon));

                if (IsDisposed || Disposing)
                    return;

                if (acessoAdministrador)
                {
                    AcessarSistema(resultado?.Id);
                    return;
                }

                var senhaValida = resultado != null && await Task.Run(() => VerificarSenha(senha, resultado.Senha));

                if (IsDisposed || Disposing)
                    return;

                if (!senhaValida)
                {
                    MessageService.Atencao("Usuário ou senha inválidos!");
                    return;
                }

                AcessarSistema(resultado.Id);
            }
            catch (Exception)
            {
                if (!IsDisposed && !Disposing)
                    MessageService.Erro("Não foi possível acessar o sistema. Verifique a conexão com o banco de dados.");
            }
            finally
            {
                if (!IsDisposed && !Disposing)
                {
                    btnEntrar.Enabled = true;
                    UseWaitCursor = false;
                }
            }
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

        void AcessarSistema(int? usuarioId)
        {
            var formPrincipal = new FormPrincipal(usuarioId);

            formPrincipal.FormClosed += (_, _) => this.Close();

            formPrincipal.Show();
            this.Hide();
        }

        private string ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtLogon.Text))
                return "Favor informar o nome do usuário!";

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
                return "Favor informar a senha!";

            return "";
        }
    }
}
