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

            bool finalizado = (int)comboStatusPesquisa.EditValue == 6;

            dataFinalizacao.Visible = finalizado;
            lblDataFinalizacao.Visible = finalizado;

            var status = (int)(bindingSourceAtividade.Current as AtividadeDTO).Status;
            var permiteAvancarOuExcluir = status < 2;

            btnAvancar.Visible = permiteAvancarOuExcluir;
            btnExcluir.Visible = permiteAvancarOuExcluir;
            btnCancelarAtividade.Visible = status >= 2 && status != 5;
        }

        void CarregaDadosExecucao()
        {
            if ((int)(bindingSourceAtividade.Current as AtividadeDTO).Status == 6)
            {
                var dadosInfoExecucao = _execucaoController.InformaDadosExecucao(_registerUserControl.IdSelecionado);
                dataGridHistoricoExecucao.DataSource = dadosInfoExecucao;
            }
        }

        void AtualizaComboBoxProjeto()
            => UIMethodsService.AtualizaComboBoxProjeto(_projetoController, comboProjetoPesquisa);

        void AtualizaComboBoxStatus()
            => UIMethodsService.AtualizaComboBoxStatus(_atividadeController, comboStatusPesquisa);

        void btnFechar_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar esta atividade? \nAs ações realizadas não serão salvas!");

        void btnSalvar_Click(object sender, EventArgs e)
        {
            var dtoAtividade = bindingSourceAtividade.Current as AtividadeDTO;

            if (comboProjetoPesquisa.EditValue != null)
                dtoAtividade.ProjetoId = (int)comboProjetoPesquisa.EditValue;

            dtoAtividade.Id = _registerUserControl.IdSelecionado;
            dtoAtividade.Descricao = txtEditorAtividade.Document.GetOpenXmlBytes(txtEditorAtividade.Document.Range);
            var retornoMensagemEdicaoAtividade = _atividadeController.Edicao(dtoAtividade, (int)comboStatusPesquisa.EditValue);

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
            if (MessageService.Pergunta("Deseja realmente excluir esta atividade? \nOs dados informados serão perdidos!") == DialogResult.Yes)
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
            dtoAtividade.ProjetoId = (int)comboProjetoPesquisa.EditValue;
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

        private void btnCancelarAtividade_Click(object sender, EventArgs e)
        {
            var dtoAtividade = bindingSourceAtividade.Current as AtividadeDTO;
            dtoAtividade.Id = _registerUserControl.IdSelecionado;

            var retornoMensagemCancela = _atividadeController.CancelarAtividade(dtoAtividade);

            if (!string.IsNullOrWhiteSpace(retornoMensagemCancela))
            {
                MessageService.Atencao(retornoMensagemCancela);
                return;
            }

            MessageService.Sucesso("Atividade cancelada! \nProcesso realizado com sucesso.");
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
