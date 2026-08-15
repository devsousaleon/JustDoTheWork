using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.UI.Core;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormCadastroAtividade : XtraForm
    {
        BindingSource _dadosAtividadeBindingSource;
        private readonly AtividadeController _atividadeController;
        private readonly ProjetoController _projetoController;

        public FormCadastroAtividade()
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _projetoController = CompositionRoot.CriarProjetoController();
        }

        void FormRegister_Load(object sender, EventArgs e)
        {
            ConfiguracaoBindingSource();
            AtualizaComboBoxProjeto();
        }

        void btnFecharAtividade_Click(object sender, EventArgs e)
            => MessageService.Acao_FecharForm_CancelarExecucao(this, "Deseja realmente fechar esta atividade? \nAs ações realizadas não serão salvas e serão perdidas!");

        void btnIncluirAtividade_Click(object sender, EventArgs e)
        {
            var dtoAtividade = (AtividadeDTO)_dadosAtividadeBindingSource.DataSource;

            if (comboProjeto.EditValue != null)
                dtoAtividade.ProjetoId = (int)comboProjeto.EditValue;

            dtoAtividade.DataCriacao = DateTime.Now.Date;
            dtoAtividade.Descricao = txtEditorAtividade.Document.GetOpenXmlBytes(txtEditorAtividade.Document.Range);

            var mensagemRetornoInclusaoAtividade = _atividadeController.Cadastro(dtoAtividade);

            if (!string.IsNullOrEmpty(mensagemRetornoInclusaoAtividade))
            {
                MessageService.Mensagem_Atencao(mensagemRetornoInclusaoAtividade);
                return;
            }

            MessageService.Mensagem_Sucesso("Atividade cadastrada com sucesso!");
            this.Close();
        }

        void ConfiguracaoBindingSource()
        {
            _dadosAtividadeBindingSource = new BindingSource();
            _dadosAtividadeBindingSource.DataSource = new AtividadeDTO();

            txtNomeAtividade.DataBindings.Add("Text", _dadosAtividadeBindingSource, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        void btnAdicionarProjeto_Click(object sender, EventArgs e)
        {
            FormCadastroProjeto _formAdicionaProjeto = new (this);
            _formAdicionaProjeto.ShowDialog();
        }

        public void AtualizaComboBoxProjeto()
            => UIMethodsService.AtualizaComboBoxProjeto(_projetoController, comboProjeto);

        void btnEditaTextoAtividade_Click(object sender, EventArgs e)
        {
            var editaTextoAtividade = new FormEditaTextoAtividade(txtEditorAtividade.RtfText);
            editaTextoAtividade.ShowDialog();
            txtEditorAtividade.RtfText = editaTextoAtividade.NovoTextoDescricaoAtividade;
        }
    }
}