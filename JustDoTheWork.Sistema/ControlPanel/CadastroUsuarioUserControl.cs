using DevExpress.XtraEditors.Controls;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Forms;
using JustDoTheWork.UI.Core;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class CadastroUsuarioUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly UsuarioController _usuarioController;

        public CadastroUsuarioUserControl()
        {
            InitializeComponent();
            DesignGrid.Configurar(gridUsuario, (colNome, 480), (colLogon, 300), (colTipoUsuario, 280));
            _usuarioController = CompositionRoot.CriarUsuarioController();
        }

        void CadastroUsuarioUserControl_Load(object sender, EventArgs e)
            => AtualizaGrid();

        void btnPesquisarUsuario_Click(object sender, EventArgs e)
            => AtualizaGrid();

        public void AtualizaGrid()
        {
            var filtro = new FiltroPesquisaUsuarioDTO
            {
                Nome = txtNomeUsuario.Text,
                Logon = txtLogon.Text
            };

            bindingSourceResultadoPesquisaUsuario.DataSource = _usuarioController.Pesquisar(filtro).ToList();
        }

        void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            using var formCadastroUsuario = new FormCadastroUsuario();

            if (formCadastroUsuario.ShowDialog(FindForm()) == DialogResult.OK)
                AtualizaGrid();
        }

        void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeUsuario.Text = string.Empty;
            txtLogon.Text = string.Empty;
            AtualizaGrid();
        }

        void repositoryButtonAcao_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (gridUsuario.GetFocusedRow() is not ResultadoPesquisaUsuarioDTO usuarioSelecionado)
                return;

            using var formCadastroUsuario = new FormCadastroUsuario(usuarioSelecionado.Id);

            if (formCadastroUsuario.ShowDialog(FindForm()) == DialogResult.OK)
                AtualizaGrid();
        }
    }
}
