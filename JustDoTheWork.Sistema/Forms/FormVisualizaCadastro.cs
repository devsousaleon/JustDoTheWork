using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.Sistema.ControlPanel;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormVisualizaCadastro : XtraForm
    {
        private readonly AtividadeController _atividadeController;
        private readonly ProjetoController _projetoController;
        private readonly ExecucaoController _execucaoController;
        private readonly VisualizaAtividadesUserControl _registerUserControl;
        private BindingSource _dadosVisualizaCadastro;

        public FormVisualizaCadastro(VisualizaAtividadesUserControl _registerUserControl)
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _projetoController = CompositionRoot.CriarProjetoController();
            _execucaoController = CompositionRoot.CriarExecucaoController();
            this._registerUserControl = _registerUserControl;
        }
        private void FormVisualizaCadastro_Load(object sender, EventArgs e)
        {
            ConfiguracaoBindingSource();
            CarregaDadosAtividade();
            AtualizaComboBoxStatus();
            AtualizaComboBoxProjeto();
            CarregaDadosExecucao();

            if ((int)comboBoxStatus.EditValue >= 2)
                btnAvancar.Visible = false;
        }
        void CarregaDadosAtividade()
        {
            var dados = _atividadeController.ObtemDadosFormAtividade(_registerUserControl.IdSelecionado);

            txtNomeAtividade.Text = dados.Nome;
            txtEditorAtividade.LoadDocument(dados.Descricao, DocumentFormat.OpenXml);
            comboBoxProjeto.EditValue = dados.ProjetoId;
            comboBoxStatus.EditValue = dados.Status;
            DataCriacao.EditValue = dados.DataCriacao;
            DataFinalizacao.EditValue = dados.DataFinalizacao;

            bool finalizado = (int)comboBoxStatus.EditValue == 6;

            DataFinalizacao.Visible = finalizado;
            lblDataFinalizacao.Visible = finalizado;
        }
        void CarregaDadosExecucao()
        {
            if ((int)comboBoxStatus.EditValue == 6)
            {
                var dadosInfoExecucao = _execucaoController.InformaDadosExecucao(_registerUserControl.IdSelecionado);  
                
                if(dadosInfoExecucao != null)
                {
                    dataGridHistoricoExecucao.DataSource = dadosInfoExecucao;
                    gridHistoricoExecucao.Columns["DataFimExecucao"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gridHistoricoExecucao.Columns["DataFimExecucao"].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
                    gridHistoricoExecucao.Columns["DataInicioExecucao"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gridHistoricoExecucao.Columns["DataInicioExecucao"].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
                }                
            }
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
           MessageService.Acao_FecharForm_CancelarExecucao(this, "Deseja realmente fechar esta atividade? \nAs ações realizadas não serão salvas!");
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var dtoAtividade = (AtividadeDTO)_dadosVisualizaCadastro.DataSource;

            if (comboBoxProjeto.EditValue != null)
                dtoAtividade.ProjetoId = (int)comboBoxProjeto.EditValue;

            dtoAtividade.Id = _registerUserControl.IdSelecionado;
            dtoAtividade.Descricao = txtEditorAtividade.Document.GetOpenXmlBytes(txtEditorAtividade.Document.Range);
            var retornoMensagemEdicaoAtividade = _atividadeController.EditaInformacaoAtividade(dtoAtividade, (int)comboBoxStatus.EditValue);

            if (!string.IsNullOrWhiteSpace(retornoMensagemEdicaoAtividade))
            {
                MessageService.Mensagem_Atencao(retornoMensagemEdicaoAtividade);
                return;
            }

            this.Close();
            _registerUserControl.AtualizaGrid();
        }
        void ConfiguracaoBindingSource()
        {
            _dadosVisualizaCadastro = new BindingSource();
            _dadosVisualizaCadastro.DataSource = new AtividadeDTO();

            txtNomeAtividade.DataBindings.Add("Text", _dadosVisualizaCadastro, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
            DataCriacao.DataBindings.Add("EditValue", _dadosVisualizaCadastro, "DataCriacao", true, DataSourceUpdateMode.OnPropertyChanged);
            DataFinalizacao.DataBindings.Add("EditValue", _dadosVisualizaCadastro, "DataFinalizacao", true, DataSourceUpdateMode.OnPropertyChanged);
        }        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            switch ((int)comboBoxStatus.EditValue)
            {
                case 2:
                case 3:
                case 4:
                    MessageService.Mensagem_Atencao("Não é possível excluir esta atividade \nHá execuções em andamento, pendente ou pausado!");
                    return;

                case 5:
                    MessageService.Mensagem_Atencao("Não é possível excluir atividade cancelada!");
                    return;
                case 6:
                    MessageService.Mensagem_Atencao("Não é possível excluir atividade finalizada!");
                    return;
            }           

            DialogResult result = MessageService.Mensagem_Pergunta("Deseja realmente excluir esta atividade? \nOs dados informados serão perdidos!");

            if(result == DialogResult.Yes)
            {
                var mensagemRetornoExclusaoAtividade = _atividadeController.Exclusao(_registerUserControl.IdSelecionado);

                if (!string.IsNullOrWhiteSpace(mensagemRetornoExclusaoAtividade))
                {
                    MessageService.Mensagem_Erro(mensagemRetornoExclusaoAtividade);
                    return;
                }

                this.Close();
                _registerUserControl.AtualizaGrid();
            }            
        }
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            var dtoAtividade = (AtividadeDTO)_dadosVisualizaCadastro.DataSource;
            dtoAtividade.ProjetoId = (int)comboBoxProjeto.EditValue;
            dtoAtividade.Id = _registerUserControl.IdSelecionado;
            dtoAtividade.Descricao = txtEditorAtividade.Document.GetOpenXmlBytes(txtEditorAtividade.Document.Range);

            var RetornoMensagemAvancaAtividade = _atividadeController.EditaInfoAvancaAtividade(dtoAtividade);

            if (!string.IsNullOrWhiteSpace(RetornoMensagemAvancaAtividade))
            {
                MessageService.Mensagem_Atencao(RetornoMensagemAvancaAtividade);
                return;
            }

            MessageService.Mensagem_Sucesso("Atividade se encontra pendente! \nProcesso realizado com sucesso.");
            this.Close();
            _registerUserControl.AtualizaGrid();
        }
        private void btnEditaTextoAtividade_Click(object sender, EventArgs e)
        {
            var editaTextoAtividade = new FormEditaTextoAtividade(txtEditorAtividade.RtfText);
            editaTextoAtividade.ShowDialog();
            txtEditorAtividade.RtfText = editaTextoAtividade.NovoTextoDescricaoAtividade;
        }
    }
}