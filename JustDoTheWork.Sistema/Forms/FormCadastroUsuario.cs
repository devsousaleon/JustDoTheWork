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
        private string _senhaAtual = string.Empty;

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
            comboTipoUsuario.Properties.DataSource = _usuarioController.ObterTiposUsuario().ToList();

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

            _senhaAtual = usuarioDTO.Senha;
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

            // O BCrypt considera até 72 bytes da senha; rejeita entradas que seriam truncadas.
            if (!string.IsNullOrWhiteSpace(usuarioDTO.Senha) && Encoding.UTF8.GetByteCount(usuarioDTO.Senha) > 72)
            {
                MessageService.Atencao("A senha excede o tamanho permitido. Use uma senha mais curta.");
                return;
            }

            var senhaParaSalvar = string.IsNullOrWhiteSpace(usuarioDTO.Senha)
                ? (emEdicao ? _senhaAtual : usuarioDTO.Senha)
                : BCrypt.Net.BCrypt.HashPassword(usuarioDTO.Senha, workFactor: 12);

            // Mantém a senha digitada no binding para permitir uma nova tentativa se o cadastro falhar.
            var usuarioParaSalvar = new UsuarioDTO
            {
                Id = usuarioDTO.Id,
                Nome = usuarioDTO.Nome,
                Logon = usuarioDTO.Logon,
                Senha = senhaParaSalvar,
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
