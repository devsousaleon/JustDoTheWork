using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.UI.Core.Geral;
using System.Text;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormCadastroUsuario : XtraForm
    {
        private readonly UsuarioController _usuarioController;
        private readonly int _idUsuario;

        public FormCadastroUsuario()
        {
            InitializeComponent();
            _usuarioController = CompositionRoot.CriarUsuarioController();
            bindingSourceUsuario.DataSource = new UsuarioDTO();
        }

        public FormCadastroUsuario(int idUsuario) : this()
        {
            _idUsuario = idUsuario;
            Text = "Edição de Usuário";
        }

        void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            comboTipoUsuario.Properties.DataSource = _usuarioController.ObterTiposUsuario();

            if (_idUsuario == 0)
                return;

            var usuarioDTO = _usuarioController.BuscarPorId(_idUsuario);

            if (usuarioDTO is null)
            {
                MessageService.Atencao("Usuário não encontrado!");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            usuarioDTO.Senha = string.Empty;
            txtSenha.Properties.NullValuePrompt = "Deixe em branco para manter a senha atual";
            bindingSourceUsuario.DataSource = usuarioDTO;
            comboTipoUsuario.EditValue = usuarioDTO.TipoUsuarioId;
        }

        void btnSalvarCadastroUsuario_Click(object sender, EventArgs e)
        {
            bindingSourceUsuario.EndEdit();
            var usuarioDTO = bindingSourceUsuario.Current as UsuarioDTO;
            usuarioDTO.TipoUsuarioId = comboTipoUsuario.EditValue is int tipoUsuarioId ? tipoUsuarioId : 0;

            var emEdicao = usuarioDTO.Id > 0;

            if (!string.IsNullOrWhiteSpace(usuarioDTO.Senha) && Encoding.UTF8.GetByteCount(usuarioDTO.Senha) > 72)
            {
                MessageService.Atencao("A senha excede o tamanho permitido. Use uma senha mais curta.");
                return;
            }

            var usuarioParaSalvar = new UsuarioDTO
            {
                Id = usuarioDTO.Id,
                Nome = usuarioDTO.Nome,
                Logon = usuarioDTO.Logon,
                Senha = usuarioDTO.Senha,
                TipoUsuarioId = usuarioDTO.TipoUsuarioId
            };

            var mensagemRetornoCadastroUsuario = emEdicao
                ? _usuarioController.Edicao(usuarioParaSalvar)
                : _usuarioController.Inclusao(usuarioParaSalvar);

            if (!string.IsNullOrWhiteSpace(mensagemRetornoCadastroUsuario))
            {
                MessageService.Atencao(mensagemRetornoCadastroUsuario);
                return;
            }

            MessageService.Sucesso(emEdicao ? "Usuário atualizado com sucesso!" : "Usuário cadastrado com sucesso!");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        void btnFecharCadastroUsuario_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar o cadastro deste usuário? \nAs ações realizadas não serão salvas!");
    }
}
