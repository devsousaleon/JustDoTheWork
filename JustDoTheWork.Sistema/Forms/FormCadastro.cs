using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.Sistema.ControlPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormCadastro : DevExpress.XtraEditors.XtraForm
    {
        RegisterUserControl _register;
        BindingSource _dadosAtividadeBindingSource;
        private readonly AtividadeController _atividadeController;
        private readonly ProjetoController _projetoController;

        public FormCadastro(RegisterUserControl register)
        {
            InitializeComponent();
            _register = register;
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

        void btnSalvarIncluirAtividade_Click(object sender, EventArgs e)
        {
            if (_register.Inclusao)
            {
                var dto = (AtividadeDTO)_dadosAtividadeBindingSource.DataSource;
                dto.ProjetoId = (int)comboProjeto.EditValue;

                var mensagem = _atividadeController.Cadastro(dto);

                if (!string.IsNullOrEmpty(mensagem))
                {
                    XtraMessageBox.Show(mensagem, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                XtraMessageBox.Show("Atividade cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {

            }
        }

        void ConfiguracaoBindingSource()
        {
            _dadosAtividadeBindingSource = new BindingSource();
            _dadosAtividadeBindingSource.DataSource = new AtividadeDTO();

            txtNomeAtividade.DataBindings.Add("Text", _dadosAtividadeBindingSource, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescricao.DataBindings.Add("Text", _dadosAtividadeBindingSource, "Descricao", true, DataSourceUpdateMode.OnPropertyChanged);
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

    }
}