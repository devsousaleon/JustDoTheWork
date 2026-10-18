using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Images;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Sistema.Forms;
using JustDoTheWork.UI.Core;
using JustDoTheWork.UI.Core.Geral;
using Timer = System.Windows.Forms.Timer;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class VisualizaExecucaoUserControl : XtraUserControl
    {
        readonly AtividadeController _atividadeController;
        readonly Timer timerAtualizaGrid;

        public int IdSelecionadoAtividade { get; private set; }

        public VisualizaExecucaoUserControl()
        {
            InitializeComponent();
            DesignGrid.Configurar(gridPendentes, (colAtividadeId, 65), (colNomeAtividade, 250), (colNomeProjeto, 180));
            DesignGrid.Configurar(gridExecutando, (colAtividadeIdExecutando, 65), (colNomeAtividadeExecutando, 350), (colNomeProjetoExecutando, 220));
            DesignGrid.Configurar(gridPausado, (colAtividadeIdPausado, 65), (colNomeAtividadePausado, 350), (colNomeProjetoPausado, 220));
            ConfigurarBotoesAcao(gridPendentes, colAcaoPendente, repositoryButtonAcaoPendente, ("Executar", StatusAtividade.Executando, "svgimages/arrows/next.svg"));
            ConfigurarBotoesAcao(gridExecutando, colAcaoExecutando, repositoryButtonAcaoExecutando, ("Pausar", StatusAtividade.Pausado, "svgimages/arrows/pause.svg"), ("Voltar para pendente", StatusAtividade.Pendente, "svgimages/history/undo.svg"), ("Finalizar", StatusAtividade.Finalizado, "svgimages/icon%20builder/actions_check.svg"));
            ConfigurarBotoesAcao(gridPausado, colAcaoPausado, repositoryButtonAcaoPausado, ("Executar", StatusAtividade.Executando, "svgimages/arrows/next.svg"), ("Voltar para pendente", StatusAtividade.Pendente, "svgimages/history/undo.svg"));
            _atividadeController = CompositionRoot.CriarAtividadeController();
            repositoryButtonAcaoPendente.ButtonClick += repositoryButtonAcaoPendente_ButtonClick;
            repositoryButtonAcaoExecutando.ButtonClick += repositoryButtonAcaoExecutando_ButtonClick;
            repositoryButtonAcaoPausado.ButtonClick += repositoryButtonAcaoPausado_ButtonClick;
            
            timerAtualizaGrid = new Timer(components) { Interval = 10000 };
            timerAtualizaGrid.Tick += timerAtualizaGrid_Tick;

        }        

        void VisualizaExecucaoUserControl_Load(object sender, EventArgs e)
        { 
            AtualizaGrid();
            timerAtualizaGrid.Start();
        }

        void AtualizaGrid()
        {
            var dados = _atividadeController.PesquisarPorStatus(2, 3, 4).ToLookup(atividade => atividade.Status);

            gridControlPendentes.DataSource = dados[StatusAtividade.Pendente].ToList();
            gridControlExecutando.DataSource = dados[StatusAtividade.Executando].ToList();
            gridControlPausado.DataSource = dados[StatusAtividade.Pausado].ToList();

            IdSelecionadoAtividade = 0;
        }

        void ConfigurarBotoesAcao(GridView gridView, GridColumn coluna, RepositoryItemButtonEdit repository, params (string legenda, StatusAtividade novoStatus, string icone)[] acoes)
        {
            const int larguraBotao = 28;
            const int espacoPorBotao = 40;
            repository.BorderStyle = BorderStyles.NoBorder;
            repository.Buttons.Clear();
            repository.Buttons.Add(new EditorButton(ButtonPredefines.Search)
            {
                ToolTip = "Visualizar atividade e histórico de execução",
                Width = larguraBotao
            });

            foreach (var (legenda, novoStatus, icone) in acoes)
            {
                var botao = new EditorButton(ButtonPredefines.Glyph)
                {
                    ToolTip = legenda,
                    Tag = novoStatus,
                    Width = larguraBotao
                };
                botao.ImageOptions.SvgImage = ImageResourceCache.Default.GetSvgImage(icone);
                botao.ImageOptions.SvgImageSize = new Size(16, 16);
                botao.ImageOptions.Location = ImageLocation.MiddleCenter;
                repository.Buttons.Add(botao);
            }

            // Reserva folga para o tamanho mínimo dos botões no tema da grid.
            var larguraColuna = repository.Buttons.Count * espacoPorBotao + 8;
            coluna.Caption = "Ações";
            coluna.OptionsColumn.FixedWidth = true;
            coluna.OptionsColumn.AllowSize = false;
            coluna.MinWidth = larguraColuna;
            coluna.MaxWidth = larguraColuna;
            coluna.Width = larguraColuna;
            gridView.RowHeight = 32;
        }

        void repositoryButtonAcaoPendente_ButtonClick(object sender, ButtonPressedEventArgs e)
            => ExecutaAcaoGrid(gridPendentes, StatusAtividade.Pendente, e.Button);

        void repositoryButtonAcaoExecutando_ButtonClick(object sender, ButtonPressedEventArgs e)
            => ExecutaAcaoGrid(gridExecutando, StatusAtividade.Executando, e.Button);

        void repositoryButtonAcaoPausado_ButtonClick(object sender, ButtonPressedEventArgs e)
            => ExecutaAcaoGrid(gridPausado, StatusAtividade.Pausado, e.Button);

        void ExecutaAcaoGrid(GridView gridView, StatusAtividade statusAtual, EditorButton botao)
        {
            if (!gridView.IsDataRow(gridView.FocusedRowHandle) || gridView.GetFocusedRow() is not ResultadoPesquisaAtividadeDTO atividade || atividade.Id <= 0)
                return;

            if (botao.Kind == ButtonPredefines.Search)
            {
                InstanciaFormPorIdSelecionado(atividade.Id);
                return;
            }

            if (botao.Tag is StatusAtividade novoStatus)
                ExecutaAcaoAlterarStatus(atividade.Id, statusAtual, novoStatus);
        }

        void InstanciaFormPorIdSelecionado(int idAtividade)
        {
            IdSelecionadoAtividade = idAtividade;
            using FormVisualizaAtividadeExecucao formVisualizaAtividadeExecucao = new(this);
            formVisualizaAtividadeExecucao.ShowDialog(FindForm());
        }

        void ExecutaAcaoAlterarStatus(int idAtividade, StatusAtividade statusAtual, StatusAtividade novoStatus)
        {
            var acaoExecutada = novoStatus == StatusAtividade.Executando ? "Inclusao" : statusAtual == StatusAtividade.Executando ? "Edicao" : string.Empty;
            var mensagemRetornoAlteracaoStatus = _atividadeController.AlterarStatus(idAtividade, (int)statusAtual, (int)novoStatus, acaoExecutada);

            if (!string.IsNullOrWhiteSpace(mensagemRetornoAlteracaoStatus))
            {
                MessageService.Atencao(mensagemRetornoAlteracaoStatus);
                return;
            }

            AtualizaGrid();
        }

        void timerAtualizaGrid_Tick(object sender, EventArgs e)
            => AtualizaGrid();
    }        
}
