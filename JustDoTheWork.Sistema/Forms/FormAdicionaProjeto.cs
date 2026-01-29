using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Composition;
using System;
using System.Windows.Forms;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormAdicionaProjeto : XtraForm
    {
        private readonly ProjetoController _controller;
        BindingSource _dadosProjetoBindingSource;
        FormCadastro _formCadastro;

        public FormAdicionaProjeto(FormCadastro formCadastro)
        {
            InitializeComponent();
            _controller = CompositionRoot.CriarProjetoController();
            _formCadastro = formCadastro;
        }
        private void FormAdicionaProjeto_Load(object sender, EventArgs e)
        {
            ConfiguracaoBindingSource();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fechar a inclusão deste projeto? \n" +
                "As ações realizadas não serão salvas e serão perdidas!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnIncluirProjeto_Click(object sender, EventArgs e)
        {
            var dto = (ProjetoDTO)_dadosProjetoBindingSource.DataSource;

            var mensagem = _controller.Inclusao(dto);

            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            XtraMessageBox.Show("Projeto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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