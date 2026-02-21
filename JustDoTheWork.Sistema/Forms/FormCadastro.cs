using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Composition;
using System;
using System.Linq;
using System.Windows.Forms;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormCadastro : XtraForm
    {
        BindingSource _dadosAtividadeBindingSource;
        private readonly AtividadeController _atividadeController;
        private readonly ProjetoController _projetoController;

        public FormCadastro()
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _projetoController = CompositionRoot.CriarProjetoController();
        }
        private void FormRegister_Load(object sender, EventArgs e)
        {
            ConfiguracaoBindingSource();
            AtualizaComboBoxProjeto();
        }

        void btnFecharAtividade_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fechar esta atividade? \n" +
                "As ações realizadas não serão salvas e serão perdidas!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                this.Close();
        }

        void btnIncluirAtividade_Click(object sender, EventArgs e)
        {
            var dto = (AtividadeDTO)_dadosAtividadeBindingSource.DataSource;

            if (comboProjeto.EditValue != null)
                dto.ProjetoId = (int)comboProjeto.EditValue;

            dto.DataCriacao = DateTime.Now;
            dto.Descricao = txtEditorAtividade.Document.GetOpenXmlBytes(txtEditorAtividade.Document.Range);

            var mensagem = _atividadeController.Cadastro(dto);

            if (!string.IsNullOrEmpty(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            XtraMessageBox.Show("Atividade cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            FormAdicionaProjeto fap = new FormAdicionaProjeto(this);
            fap.ShowDialog();
        }

        public void AtualizaComboBoxProjeto()
        {
            var dados = _projetoController.PesquisarParaCombo().ToList();

            if (dados == null)
                return;

            comboProjeto.Properties.DataSource = dados;
            comboProjeto.Properties.DisplayMember = "Nome";
            comboProjeto.Properties.ValueMember = "Id";
            comboProjeto.Properties.NullText = "Selecione um projeto";
        }

        private void btnEditaTextoAtividade_Click(object sender, EventArgs e)
        {
            var editaTextoAtividade = new FormEditaTextoAtividade(txtEditorAtividade.RtfText);
            editaTextoAtividade.ShowDialog();
            txtEditorAtividade.RtfText = editaTextoAtividade.NovoTextoDescricaoAtividade;
        }
    }
}