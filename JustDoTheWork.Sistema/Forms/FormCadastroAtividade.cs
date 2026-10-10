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
            bindingSourceAtividade.DataSource = new AtividadeDTO();
        }

        void FormCadastroAtividade_Load(object sender, EventArgs e)
        {
            AtualizaComboBoxProjeto();
        }

        void btnFecharCadastroAtividade_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar esta atividade? \nAs ações realizadas não serão salvas e serão perdidas!");

        void btnSalvarCadastroAtividade_Click(object sender, EventArgs e)
        {
            var atividadeDTO = bindingSourceAtividade.Current as AtividadeDTO;

            if (comboProjeto.EditValue != null)
                atividadeDTO.ProjetoId = (int)comboProjeto.EditValue;

            atividadeDTO.DataCriacao = DateTime.Now.Date;
            atividadeDTO.Descricao = richEditDescricaoAtividade.Document.GetOpenXmlBytes(richEditDescricaoAtividade.Document.Range);

            var mensagemRetornoInclusaoAtividade = _atividadeController.Inclusao(atividadeDTO);

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
            FormCadastroProjeto formCadastroProjeto = new (this);
            formCadastroProjeto.ShowDialog();
        }

        public void AtualizaComboBoxProjeto()
            => UIMethodsService.AtualizaComboBoxProjeto(_projetoController, comboProjeto);

        void btnEditarTextoAtividade_Click(object sender, EventArgs e)
        {
            FormEditaTexto formEditaTexto = new FormEditaTexto(richEditDescricaoAtividade.RtfText);
            formEditaTexto.ShowDialog();
            richEditDescricaoAtividade.RtfText = formEditaTexto.TextoEditado;
        }
    }
}
