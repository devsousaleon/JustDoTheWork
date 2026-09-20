using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.UI.Core;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormCadastroAtividade : XtraForm
    {
        private readonly AtividadeController _atividadeController;
        private readonly ProjetoController _projetoController;

        public FormCadastroAtividade()
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _projetoController = CompositionRoot.CriarProjetoController();
            BindingSourceAtividade.DataSource = new AtividadeDTO();
        }

        void FormRegister_Load(object sender, EventArgs e)
        {
            AtualizaComboBoxProjeto();
        }

        void btnFecharAtividade_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar esta atividade? \nAs ações realizadas não serão salvas e serão perdidas!");

        void btnIncluirAtividade_Click(object sender, EventArgs e)
        {
            var dtoAtividade = BindingSourceAtividade.Current as AtividadeDTO;

            if (comboProjeto.EditValue != null)
                dtoAtividade.ProjetoId = (int)comboProjeto.EditValue;

            dtoAtividade.DataCriacao = DateTime.Now.Date;
            dtoAtividade.Descricao = txtEditorAtividade.Document.GetOpenXmlBytes(txtEditorAtividade.Document.Range);

            var mensagemRetornoInclusaoAtividade = _atividadeController.Cadastro(dtoAtividade);

            if (!string.IsNullOrEmpty(mensagemRetornoInclusaoAtividade))
            {
                MessageService.Atencao(mensagemRetornoInclusaoAtividade);
                return;
            }

            MessageService.Sucesso("Atividade cadastrada com sucesso!");
            this.Close();
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
