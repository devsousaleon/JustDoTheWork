using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormCadastroProjeto : XtraForm
    {
        private readonly ProjetoController _controller;
        FormCadastroAtividade _formCadastro;

        public FormCadastroProjeto(FormCadastroAtividade _formCadastro)
        {
            InitializeComponent();
            _controller = CompositionRoot.CriarProjetoController();
            this._formCadastro = _formCadastro;
            bindingSourceProjetoDTO.DataSource = new ProjetoDTO();
        }

        void btnCancelar_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar a inclusão deste projeto? \nAs ações realizadas não serão salvas e serão perdidas!");
        
        void btnIncluirProjeto_Click(object sender, EventArgs e)
        {
            var mensagemRetornoInclusaoProjeto = _controller.Inclusao(bindingSourceProjetoDTO.Current as ProjetoDTO);

            if (!string.IsNullOrWhiteSpace(mensagemRetornoInclusaoProjeto))
            {
                MessageService.Atencao(mensagemRetornoInclusaoProjeto);
                return;
            }

            MessageService.Sucesso("Projeto cadastrado com sucesso!");
            _formCadastro.AtualizaComboBoxProjeto();
            this.Close();
        }
    }
}
