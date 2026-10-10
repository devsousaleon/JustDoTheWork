using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormCadastroProjeto : XtraForm
    {
        private readonly ProjetoController _projetoController;
        FormCadastroAtividade _formCadastroAtividade;

        public FormCadastroProjeto(FormCadastroAtividade formCadastroAtividade)
        {
            InitializeComponent();
            _projetoController = CompositionRoot.CriarProjetoController();
            this._formCadastroAtividade = formCadastroAtividade;
            bindingSourceProjeto.DataSource = new ProjetoDTO();
        }

        void btnFecharCadastroProjeto_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar a inclusão deste projeto? \nAs ações realizadas não serão salvas e serão perdidas!");
        
        void btnSalvarCadastroProjeto_Click(object sender, EventArgs e)
        {
            var mensagemRetornoInclusaoProjeto = _projetoController.Inclusao(bindingSourceProjeto.Current as ProjetoDTO);

            if (!string.IsNullOrWhiteSpace(mensagemRetornoInclusaoProjeto))
            {
                MessageService.Atencao(mensagemRetornoInclusaoProjeto);
                return;
            }

            MessageService.Sucesso("Projeto cadastrado com sucesso!");
            _formCadastroAtividade.AtualizaComboBoxProjeto();
            this.Close();
        }
    }
}
