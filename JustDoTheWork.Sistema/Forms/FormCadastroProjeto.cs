using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormCadastroProjeto : XtraForm
    {
        private readonly ProjetoController _controller;
        BindingSource _dadosProjetoBindingSource;
        FormCadastroAtividade _formCadastro;

        public FormCadastroProjeto(FormCadastroAtividade _formCadastro)
        {
            InitializeComponent();
            _controller = CompositionRoot.CriarProjetoController();
            this._formCadastro = _formCadastro;
        }

        void FormAdicionaProjeto_Load(object sender, EventArgs e)
            => ConfiguracaoBindingSource();

        void btnCancelar_Click(object sender, EventArgs e)
            => MessageService.Acao_FecharForm_CancelarExecucao(this, "Deseja realmente fechar a inclusão deste projeto? \nAs ações realizadas não serão salvas e serão perdidas!");
        
        void btnIncluirProjeto_Click(object sender, EventArgs e)
        {
            var dtoProjeto = (ProjetoDTO)_dadosProjetoBindingSource.DataSource;

            var mensagemRetornoInclusaoProjeto = _controller.Inclusao(dtoProjeto);

            if (!string.IsNullOrWhiteSpace(mensagemRetornoInclusaoProjeto))
            {
                MessageService.Mensagem_Atencao(mensagemRetornoInclusaoProjeto);
                return;
            }

            MessageService.Mensagem_Sucesso("Projeto cadastrado com sucesso!");
            _formCadastro.AtualizaComboBoxProjeto();
            this.Close();
        }
        
        void ConfiguracaoBindingSource()
        {
            _dadosProjetoBindingSource = new BindingSource();
            _dadosProjetoBindingSource.DataSource = new ProjetoDTO();

            txtNomeProjeto.DataBindings.Add("Text", _dadosProjetoBindingSource, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}