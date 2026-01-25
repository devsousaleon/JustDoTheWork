using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.Sistema.ControlPanel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormVisualizaCadastro : DevExpress.XtraEditors.XtraForm
    {
        private readonly AtividadeController _atividadeController;
        private readonly ProjetoController _projetoController;
        private readonly RegisterUserControl _ruc;
        private BindingSource _dadosVisualizaCadastro;

        public FormVisualizaCadastro(RegisterUserControl ruc)
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _projetoController = CompositionRoot.CriarProjetoController();
            _ruc = ruc;
        }

        private void FormVisualizaCadastro_Load(object sender, EventArgs e)
        {
            ConfiguracaoBindingSource();
            CarregaDadosAtividade();
            AtualizaComboBoxStatus();
            AtualizaComboBoxProjeto();

            if ((int)comboBoxStatus.EditValue == 2)
                btnAvancar.Enabled = false;
        }

        void CarregaDadosAtividade()
        {
            var dados = _atividadeController.ObtemDadosFormAtividade(_ruc.IdSelecionado);

            txtNomeAtividade.Text = dados.Nome;
            txtDescricao.Text = dados.Descricao;
            comboBoxProjeto.EditValue = dados.ProjetoId;
            comboBoxStatus.EditValue = dados.Status;
            DataCriacao.EditValue = dados.DataCriacao;
            DataFinalizacao.EditValue = dados.DataFinalizacao;
        }

        void AtualizaComboBoxProjeto()
        {
            var dados = _projetoController.PesquisarParaCombo().ToList();

            if (dados == null)
                return;

            comboBoxProjeto.Properties.DataSource = dados;
            comboBoxProjeto.Properties.DisplayMember = "Nome";
            comboBoxProjeto.Properties.ValueMember = "Id";
            comboBoxProjeto.Properties.NullText = "Selecione um projeto";
        }

        void AtualizaComboBoxStatus()
        {
            comboBoxStatus.Properties.DataSource = _atividadeController.ObterStatusAtividade();

            comboBoxStatus.Properties.DisplayMember = "Status";
            comboBoxStatus.Properties.ValueMember = "Id";
            comboBoxStatus.Properties.NullText = "Selecione uma opção";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fechar esta atividade? \n" +
                "As ações realizadas não serão salvas e serão perdidas!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var dto = (AtividadeDTO)_dadosVisualizaCadastro.DataSource;

            if (comboBoxProjeto.EditValue != null)
                dto.ProjetoId = (int)comboBoxProjeto.EditValue;

            dto.Id = _ruc.IdSelecionado;

            var mensagem = _atividadeController.EditaInformacaoAtividade(dto);

            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Close();
            _ruc.AtualizaGrid();
        }

        void ConfiguracaoBindingSource()
        {
            _dadosVisualizaCadastro = new BindingSource();
            _dadosVisualizaCadastro.DataSource = new AtividadeDTO();

            txtNomeAtividade.DataBindings.Add("Text", _dadosVisualizaCadastro, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescricao.DataBindings.Add("Text", _dadosVisualizaCadastro, "Descricao", true, DataSourceUpdateMode.OnPropertyChanged);
            DataCriacao.DataBindings.Add("EditValue", _dadosVisualizaCadastro, "DataCriacao", true, DataSourceUpdateMode.OnPropertyChanged);
            DataFinalizacao.DataBindings.Add("EditValue", _dadosVisualizaCadastro, "DataFinalizacao", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if((int)comboBoxStatus.EditValue > 2) 
            {
                XtraMessageBox.Show("Não é possível excluir este projeto \n" +
                                    "Há execuções em andamento, pendente ou finalizada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var mensagem = _atividadeController.Exclusao(_ruc.IdSelecionado);

            if(!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Close();
            _ruc.AtualizaGrid();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            var dto = (AtividadeDTO)_dadosVisualizaCadastro.DataSource;

            dto.ProjetoId = (int)comboBoxProjeto.EditValue;

            dto.Id = _ruc.IdSelecionado;

            var mensagem = _atividadeController.EditaInfoAvancaAtividade(dto);

            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                XtraMessageBox.Show(mensagem, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            XtraMessageBox.Show("Atividade se encontra pendente para execução! \n" +
                                "Processo realizado com sucesso", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            _ruc.AtualizaGrid();

        }
    }
}