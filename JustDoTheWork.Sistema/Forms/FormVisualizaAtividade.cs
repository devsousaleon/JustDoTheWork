using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.ControlPanel;
using JustDoTheWork.UI.Core;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormVisualizaAtividade : XtraForm
    {
        private readonly AtividadeController _atividadeController;
        private readonly ProjetoController _projetoController;
        private readonly ExecucaoController _execucaoController;
        private readonly CadastroAtividadeUserControl _cadastroAtividadeUserControl;

        public FormVisualizaAtividade(CadastroAtividadeUserControl cadastroAtividadeUserControl)
        {
            InitializeComponent();
            DesignGrid.Configurar(gridHistoricoExecucao, (colAtividadeId, 70), (colDataInicioExecucao, 240), (colDataFimExecucao, 240));
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _projetoController = CompositionRoot.CriarProjetoController();
            _execucaoController = CompositionRoot.CriarExecucaoController();
            this._cadastroAtividadeUserControl = cadastroAtividadeUserControl;
        }

        void FormVisualizaAtividade_Load(object sender, EventArgs e)
        {
            AtualizaComboBoxStatus();
            AtualizaComboBoxProjeto();
            CarregaDadosAtividade();
            CarregaDadosExecucao();
        }

        void CarregaDadosAtividade()
        {
            bindingSourceAtividade.DataSource = _atividadeController.BuscarPorId(_cadastroAtividadeUserControl.IdSelecionado);

            bool finalizado = (int)comboStatus.EditValue == 6;

            dataFinalizacao.Visible = finalizado;
            lblDataFinalizacao.Visible = finalizado;

            var status = (int)(bindingSourceAtividade.Current as AtividadeDTO).Status;
            var permiteAvancarOuExcluir = status < 2;

            btnAvancarAtividade.Visible = permiteAvancarOuExcluir;
            btnExcluirAtividade.Visible = permiteAvancarOuExcluir;
            btnCancelarAtividade.Visible = status >= 2 && status != 5;
        }

        void CarregaDadosExecucao()
        {
            if ((int)(bindingSourceAtividade.Current as AtividadeDTO).Status == 6)
            {
                var dadosInfoExecucao = _execucaoController.BuscarPorAtividadeId(_cadastroAtividadeUserControl.IdSelecionado);
                gridControlHistoricoExecucao.DataSource = dadosInfoExecucao;
            }
        }

        void AtualizaComboBoxProjeto()
            => UIMethodsService.AtualizaComboBoxProjeto(_projetoController, comboProjeto);

        void AtualizaComboBoxStatus()
            => UIMethodsService.AtualizaComboBoxStatus(_atividadeController, comboStatus);

        void btnFecharCadastroAtividade_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar esta atividade? \nAs ações realizadas não serão salvas!");

        void btnSalvarCadastroAtividade_Click(object sender, EventArgs e)
        {
            var atividadeDTO = bindingSourceAtividade.Current as AtividadeDTO;

            if (comboProjeto.EditValue != null)
                atividadeDTO.ProjetoId = (int)comboProjeto.EditValue;

            atividadeDTO.Id = _cadastroAtividadeUserControl.IdSelecionado;
            atividadeDTO.Descricao = richEditDescricaoAtividade.Document.GetOpenXmlBytes(richEditDescricaoAtividade.Document.Range);
            var retornoMensagemEdicaoAtividade = _atividadeController.Edicao(atividadeDTO, (int)comboStatus.EditValue);

            if (!string.IsNullOrWhiteSpace(retornoMensagemEdicaoAtividade))
            {
                MessageService.Atencao(retornoMensagemEdicaoAtividade);
                return;
            }

            this.Close();
            _cadastroAtividadeUserControl.AtualizaGrid();
        }

        void btnExcluirAtividade_Click(object sender, EventArgs e)
        {
            if (MessageService.Pergunta("Deseja realmente excluir esta atividade? \nOs dados informados serão perdidos!") == DialogResult.Yes)
            {
                var mensagemRetornoExclusaoAtividade = _atividadeController.Exclusao(_cadastroAtividadeUserControl.IdSelecionado);

                if (!string.IsNullOrWhiteSpace(mensagemRetornoExclusaoAtividade))
                {
                    MessageService.Erro(mensagemRetornoExclusaoAtividade);
                    return;
                }

                this.Close();
                _cadastroAtividadeUserControl.AtualizaGrid();
            }
        }

        void btnAvancarAtividade_Click(object sender, EventArgs e)
        {
            var atividadeDTO = bindingSourceAtividade.Current as AtividadeDTO;
            atividadeDTO.ProjetoId = (int)comboProjeto.EditValue;
            atividadeDTO.Id = _cadastroAtividadeUserControl.IdSelecionado;
            atividadeDTO.Descricao = richEditDescricaoAtividade.Document.GetOpenXmlBytes(richEditDescricaoAtividade.Document.Range);

            var retornoMensagemAvancaAtividade = _atividadeController.AvancarAtividade(atividadeDTO);

            if (!string.IsNullOrWhiteSpace(retornoMensagemAvancaAtividade))
            {
                MessageService.Atencao(retornoMensagemAvancaAtividade);
                return;
            }

            MessageService.Sucesso("Atividade se encontra pendente! \nProcesso realizado com sucesso.");
            this.Close();
            _cadastroAtividadeUserControl.AtualizaGrid();
        }

        private void btnCancelarAtividade_Click(object sender, EventArgs e)
        {
            var atividadeDTO = bindingSourceAtividade.Current as AtividadeDTO;
            atividadeDTO.Id = _cadastroAtividadeUserControl.IdSelecionado;

            var retornoMensagemCancela = _atividadeController.CancelarAtividade(atividadeDTO);

            if (!string.IsNullOrWhiteSpace(retornoMensagemCancela))
            {
                MessageService.Atencao(retornoMensagemCancela);
                return;
            }

            MessageService.Sucesso("Atividade cancelada! \nProcesso realizado com sucesso.");
            this.Close();
            _cadastroAtividadeUserControl.AtualizaGrid();
        }

        void btnEditarTextoAtividade_Click(object sender, EventArgs e)
        {
            FormEditaTexto formEditaTexto = new FormEditaTexto(richEditDescricaoAtividade.RtfText);
            formEditaTexto.ShowDialog();
            richEditDescricaoAtividade.RtfText = formEditaTexto.TextoEditado;
        }
    }
}
