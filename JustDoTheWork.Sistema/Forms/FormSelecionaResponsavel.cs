using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public class FormSelecionaResponsavel : XtraForm
    {
        private readonly LookUpEdit comboUsuarioResponsavel = new();
        private readonly SimpleButton btnConfirmarResponsavel = new();
        private readonly SimpleButton btnCancelar = new();

        private FormSelecionaResponsavel(string tipoUsuario, List<UsuarioSelecaoDTO> usuarios)
        {
            Text = "Selecionar responsável";
            Name = nameof(FormSelecionaResponsavel);
            ClientSize = new Size(480, 170);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;

            var lblResponsavel = new LabelControl { Text = "Selecione o responsável: " + tipoUsuario, Location = new Point(20, 20) };
            comboUsuarioResponsavel.Name = nameof(comboUsuarioResponsavel);
            comboUsuarioResponsavel.EnterMoveNextControl = true;
            comboUsuarioResponsavel.Location = new Point(20, 52);
            comboUsuarioResponsavel.Size = new Size(440, 30);
            comboUsuarioResponsavel.Properties.DataSource = usuarios;
            comboUsuarioResponsavel.Properties.DisplayMember = nameof(UsuarioSelecaoDTO.Nome);
            comboUsuarioResponsavel.Properties.ValueMember = nameof(UsuarioSelecaoDTO.Id);
            comboUsuarioResponsavel.Properties.NullText = "Selecione um usuário";
            comboUsuarioResponsavel.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            comboUsuarioResponsavel.Properties.Columns.Add(new LookUpColumnInfo(nameof(UsuarioSelecaoDTO.Nome), "Nome"));
            btnConfirmarResponsavel.Name = nameof(btnConfirmarResponsavel);
            btnConfirmarResponsavel.Text = "Confirmar";
            btnConfirmarResponsavel.Location = new Point(252, 116);
            btnConfirmarResponsavel.Size = new Size(100, 30);
            btnConfirmarResponsavel.Click += btnConfirmarResponsavel_Click;
            btnCancelar.Name = nameof(btnCancelar);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(360, 116);
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.DialogResult = DialogResult.Cancel;
            AcceptButton = btnConfirmarResponsavel;
            CancelButton = btnCancelar;
            Controls.AddRange(new Control[] { lblResponsavel, comboUsuarioResponsavel, btnConfirmarResponsavel, btnCancelar });
        }

        private void btnConfirmarResponsavel_Click(object sender, EventArgs e)
        {
            if (comboUsuarioResponsavel.EditValue is not int id || id <= 0)
            {
                MessageService.Atencao("Selecione o usuário responsável antes de continuar.");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        public static int? Selecionar(IWin32Window dono, string tipoUsuario)
        {
            var usuarios = CompositionRoot.CriarUsuarioController().PesquisarPorTipo(tipoUsuario).ToList();
            if (usuarios.Count == 0)
            {
                MessageService.Atencao("Não há usuários cadastrados do tipo " + tipoUsuario + ".");
                return null;
            }
            using var formSelecionaResponsavel = new FormSelecionaResponsavel(tipoUsuario, usuarios);
            return formSelecionaResponsavel.ShowDialog(dono) == DialogResult.OK
                ? (int?)formSelecionaResponsavel.comboUsuarioResponsavel.EditValue : null;
        }
    }
}
