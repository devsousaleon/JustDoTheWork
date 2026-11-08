using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Sistema.ControlPanel;
using JustDoTheWork.Sistema.Services;
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
        private readonly int _idAtividade;
        private readonly SimpleButton _btnDevolverDesenvolvedor;
        private byte[] _descricaoOriginal;
        private bool _descricaoEditada;

        public FormVisualizaAtividade(CadastroAtividadeUserControl cadastroAtividadeUserControl) : this(cadastroAtividadeUserControl.IdSelecionado)
        {
            _cadastroAtividadeUserControl = cadastroAtividadeUserControl;
        }

        public FormVisualizaAtividade(int idAtividade)
        {
            InitializeComponent();
            richEditDescricaoAtividade.DataBindings.Clear();
            _idAtividade = idAtividade;
            DesignGrid.Configurar(gridHistoricoExecucao, (colAtividadeId, 70), (colDataInicioExecucao, 240), (colDataFimExecucao, 240));
            _atividadeController = CompositionRoot.CriarAtividadeController();
            _projetoController = CompositionRoot.CriarProjetoController();
            _execucaoController = CompositionRoot.CriarExecucaoController();
            var colUsuario = gridHistoricoExecucao.Columns.AddVisible("Usuario", "Autor da execução");
            var colEtapa = gridHistoricoExecucao.Columns.AddVisible("NomeEtapa", "Etapa da execução");
            DesignGrid.Configurar(gridHistoricoExecucao, (colUsuario, 180), (colEtapa, 145));
            colAtividadeId.VisibleIndex = 0;
            colUsuario.VisibleIndex = 1;
            colEtapa.VisibleIndex = 2;
            colDataInicioExecucao.VisibleIndex = 3;
            colDataFimExecucao.VisibleIndex = 4;
            _btnDevolverDesenvolvedor = new SimpleButton { Text = "Devolver ao desenvolvedor", Width = 190, Height = btnAvancarAtividade.Height, Anchor = btnAvancarAtividade.Anchor, Visible = false };
            _btnDevolverDesenvolvedor.Appearance.Font = btnAvancarAtividade.Appearance.Font;
            _btnDevolverDesenvolvedor.Appearance.Options.UseFont = true;
            btnAvancarAtividade.Parent.Controls.Add(_btnDevolverDesenvolvedor);
            _btnDevolverDesenvolvedor.Click += btnDevolverDesenvolvedor_Click;
        }

        void FormVisualizaAtividade_Load(object sender, EventArgs e)
        {
            AtualizaComboBoxStatus();
            AtualizaComboBoxProjeto();
            CarregaDadosAtividade();
        }

        void CarregaDadosAtividade()
        {
            var atividade = _atividadeController.BuscarPorId(_idAtividade);
            if (atividade == null)
            {
                MessageService.Atencao("Atividade não encontrada ou sem permissão de acesso. Atualize a pesquisa.");
                Close();
                return;
            }
            bindingSourceAtividade.DataSource = atividade;
            _descricaoOriginal = atividade.Descricao;
            _descricaoEditada = false;
            if (atividade.Descricao is { Length: > 0 })
                richEditDescricaoAtividade.LoadDocument(atividade.Descricao, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
            else
                richEditDescricaoAtividade.CreateNewDocument();
            var podeMovimentar = _atividadeController.PodeMovimentar(atividade);
            var podeEditar = _atividadeController.PodeEditar(atividade);
            var podeVincular = CompositionRoot.UsuarioAtual?.EhTechLead == true && !atividade.UsuarioResponsavelId.HasValue && FluxoAtividade.EstaAberta(atividade.Status);
            groupInfoAtividade.Text = $"Etapa: {FluxoAtividade.NomeEtapa(atividade.Etapa)} — Responsável: {atividade.Responsavel}";
            dataFinalizacao.Visible = atividade.DataFinalizacao.HasValue;
            lblDataFinalizacao.Visible = atividade.DataFinalizacao.HasValue;
            txtNomeAtividade.Properties.ReadOnly = !podeEditar;
            comboProjeto.Properties.ReadOnly = !podeEditar;
            comboStatus.Properties.ReadOnly = true;
            btnEditarTextoAtividade.Visible = podeEditar;
            btnSalvarCadastroAtividade.Visible = podeEditar;
            btnAvancarAtividade.Visible = podeMovimentar || podeVincular;
            btnAvancarAtividade.Text = podeVincular ? "Vincular responsável" : atividade.Etapa == EtapaAtividade.QATester ? "Finalizar atividade" : "Avançar etapa";
            btnAvancarAtividade.Width = 180;
            btnExcluirAtividade.Visible = _atividadeController.PodeExcluir(atividade);
            btnCancelarAtividade.Visible = _atividadeController.PodeCancelar(atividade);
            btnExcluirAtividade.Location = new Point(485, 10);
            _btnDevolverDesenvolvedor.Visible = podeMovimentar && atividade.Etapa == EtapaAtividade.QATester;
            _btnDevolverDesenvolvedor.Location = new Point(btnExcluirAtividade.Right + 16, btnAvancarAtividade.Top);
            gridControlHistoricoExecucao.DataSource = _execucaoController.BuscarPorAtividadeId(_idAtividade);
        }

        void AtualizaComboBoxProjeto()
            => UIMethodsService.AtualizaComboBoxProjeto(_projetoController, comboProjeto);

        void AtualizaComboBoxStatus()
            => UIMethodsService.AtualizaComboBoxStatus(_atividadeController, comboStatus);

        AtividadeDTO ObterDadosEdicao()
        {
            bindingSourceAtividade.EndEdit();
            var atividade = (AtividadeDTO)bindingSourceAtividade.Current;
            if (comboProjeto.EditValue is int projetoId)
                atividade.ProjetoId = projetoId;
            atividade.Descricao = _descricaoEditada ? richEditDescricaoAtividade.Document.GetOpenXmlBytes(richEditDescricaoAtividade.Document.Range) : _descricaoOriginal;
            return atividade;
        }

        void ConcluirAlteracao(string mensagem)
        {
            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                MessageService.Atencao(mensagem);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
            _cadastroAtividadeUserControl?.AtualizaGrid();
        }

        void btnFecharCadastroAtividade_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar esta atividade?\nAs alterações não salvas serão perdidas.");

        void btnSalvarCadastroAtividade_Click(object sender, EventArgs e)
        {
            var atividade = ObterDadosEdicao();
            ConcluirAlteracao(_atividadeController.Edicao(atividade, (int)atividade.Status));
        }

        void btnExcluirAtividade_Click(object sender, EventArgs e)
        {
            if (MessageService.Pergunta("Deseja realmente excluir esta atividade?") == DialogResult.Yes)
                ConcluirAlteracao(_atividadeController.Exclusao((AtividadeDTO)bindingSourceAtividade.Current));
        }

        void btnAvancarAtividade_Click(object sender, EventArgs e)
        {
            var atividade = (AtividadeDTO)bindingSourceAtividade.Current;
            if (CompositionRoot.UsuarioAtual?.EhTechLead == true && !atividade.UsuarioResponsavelId.HasValue)
            {
                var responsavelId = FormSelecionaResponsavel.Selecionar(this, FluxoAtividade.TipoUsuarioPorEtapa(atividade.Etapa));
                if (responsavelId.HasValue)
                    ConcluirAlteracao(_atividadeController.VincularResponsavel(atividade, responsavelId.Value));
                return;
            }
            if (FluxoAtividadeService.AvancarAtividade(_atividadeController, ObterDadosEdicao(), this))
                ConcluirAlteracao("");
        }

        void btnCancelarAtividade_Click(object sender, EventArgs e)
        {
            if (MessageService.Pergunta("Deseja realmente cancelar esta atividade?") == DialogResult.Yes)
                ConcluirAlteracao(_atividadeController.CancelarAtividade((AtividadeDTO)bindingSourceAtividade.Current));
        }

        void btnDevolverDesenvolvedor_Click(object sender, EventArgs e)
        {
            if (MessageService.Pergunta("Deseja devolver esta atividade ao desenvolvedor anterior para correção?") == DialogResult.Yes)
                ConcluirAlteracao(_atividadeController.DevolverDesenvolvedor(ObterDadosEdicao()));
        }

        void btnEditarTextoAtividade_Click(object sender, EventArgs e)
        {
            using var formEditaTexto = new FormEditaTexto(richEditDescricaoAtividade.RtfText);
            if (formEditaTexto.ShowDialog(this) == DialogResult.OK)
            {
                richEditDescricaoAtividade.RtfText = formEditaTexto.TextoEditado;
                _descricaoEditada = true;
            }
        }
    }
}
