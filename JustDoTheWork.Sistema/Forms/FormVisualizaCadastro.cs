using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.ControlPanel;
using JustDoTheWork.UI.Core;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormVisualizaCadastro : XtraForm
    {
        private readonly AtividadeController _atividadeController;
        private readonly ProjetoController _projetoController;
        private readonly ExecucaoController _execucaoController;
        private readonly VisualizaAtividadesUserControl _registerUserControl;

        public FormVisualizaCadastro(VisualizaAtividadesUserControl _registerUserControl)
        {
            InitializeComponent();
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _projetoController = CompositionRoot.CriarProjetoController();
            _execucaoController = CompositionRoot.CriarExecucaoController();
            this._registerUserControl = _registerUserControl;
        }

        void FormVisualizaCadastro_Load(object sender, EventArgs e)
        {
            AtualizaComboBoxStatus();
            AtualizaComboBoxProjeto();
            CarregaDadosAtividade();            
            CarregaDadosExecucao();
        }

        void CarregaDadosAtividade()
        {
            bindingSourceAtividade.DataSource = _atividadeController.ObtemDadosFormAtividade(_registerUserControl.IdSelecionado);

            bool finalizado = (int)comboBoxStatus.EditValue == 6;

            DataFinalizacao.Visible = finalizado;
            lblDataFinalizacao.Visible = finalizado;

            if (bindingSourceAtividade.Current is AtividadeDTO a && (int)a.Status >= 2)
                btnAvancar.Visible = false;
        }
        void CarregaDadosExecucao()
        {
            if (bindingSourceAtividade.Current is AtividadeDTO a && (int)a.Status == 6)
            {
                var dadosInfoExecucao = _execucaoController.InformaDadosExecucao(_registerUserControl.IdSelecionado);
                dataGridHistoricoExecucao.DataSource = dadosInfoExecucao;
            }
        }

        void AtualizaComboBoxProjeto()
            => UIMethodsService.AtualizaComboBoxProjeto(_projetoController, comboBoxProjeto);

        void AtualizaComboBoxStatus()
            => UIMethodsService.AtualizaComboBoxStatus(_atividadeController, comboBoxStatus);

        void btnFechar_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar esta atividade? \nAs ações realizadas não serão salvas!");

        void btnSalvar_Click(object sender, EventArgs e)
        {
            var dtoAtividade = bindingSourceAtividade.Current as AtividadeDTO;

            if (comboBoxProjeto.EditValue != null)
                dtoAtividade.ProjetoId = (int)comboBoxProjeto.EditValue;

            dtoAtividade.Id = _registerUserControl.IdSelecionado;
            dtoAtividade.Descricao = txtEditorAtividade.Document.GetOpenXmlBytes(txtEditorAtividade.Document.Range);
            var retornoMensagemEdicaoAtividade = _atividadeController.Edicao(dtoAtividade, (int)comboBoxStatus.EditValue);

            if (!string.IsNullOrWhiteSpace(retornoMensagemEdicaoAtividade))
            {
                MessageService.Atencao(retornoMensagemEdicaoAtividade);
                return;
            }

            this.Close();
            _registerUserControl.AtualizaGrid();
        } 
        
        void btnExcluir_Click(object sender, EventArgs e)
        {
            switch ((int)comboBoxStatus.EditValue)
            {
                case 2:
                case 3:
                case 4:
                    MessageService.Atencao("Não é possível excluir esta atividade \nHá execuções em andamento, pendente ou pausado!");
                    return;

                case 5:
                    MessageService.Atencao("Não é possível excluir atividade cancelada!");
                    return;

                case 6:
                    MessageService.Atencao("Não é possível excluir atividade finalizada!");
                    return;
            }

            if(MessageService.Pergunta("Deseja realmente excluir esta atividade? \nOs dados informados serão perdidos!") == DialogResult.Yes)
            {
                var mensagemRetornoExclusaoAtividade = _atividadeController.Exclusao(_registerUserControl.IdSelecionado);

                if (!string.IsNullOrWhiteSpace(mensagemRetornoExclusaoAtividade))
                {
                    MessageService.Erro(mensagemRetornoExclusaoAtividade);
                    return;
                }

                this.Close();
                _registerUserControl.AtualizaGrid();
            }            
        }

        void btnAvancar_Click(object sender, EventArgs e)
        {
            var dtoAtividade = bindingSourceAtividade.Current as AtividadeDTO;
            dtoAtividade.ProjetoId = (int)comboBoxProjeto.EditValue;
            dtoAtividade.Id = _registerUserControl.IdSelecionado;
            dtoAtividade.Descricao = txtEditorAtividade.Document.GetOpenXmlBytes(txtEditorAtividade.Document.Range);

            var RetornoMensagemAvancaAtividade = _atividadeController.AvancarAtividade(dtoAtividade);

            if (!string.IsNullOrWhiteSpace(RetornoMensagemAvancaAtividade))
            {
                MessageService.Atencao(RetornoMensagemAvancaAtividade);
                return;
            }

            MessageService.Sucesso("Atividade se encontra pendente! \nProcesso realizado com sucesso.");
            this.Close();
            _registerUserControl.AtualizaGrid();
        }

        void btnEditaTextoAtividade_Click(object sender, EventArgs e)
        {
            var editaTextoAtividade = new FormEditaTextoAtividade(txtEditorAtividade.RtfText);
            editaTextoAtividade.ShowDialog();
            txtEditorAtividade.RtfText = editaTextoAtividade.NovoTextoDescricaoAtividade;
        }
    }
}