using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.Sistema.ControlPanel;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormVisualizaModeloRelatorio : XtraForm
    {
        private readonly TipoModeloController _tipoModeloController;
        private readonly ModeloRelatorioController _modeloRelatorioController;
        private readonly CadastroModeloRelatorioUserControl _cadastroModeloRelatorioUserControl;

        public FormVisualizaModeloRelatorio(CadastroModeloRelatorioUserControl cadastroModeloRelatorioUserControl)
        {
            InitializeComponent();
            _tipoModeloController = CompositionRoot.CriarTipoModeloController();
            _modeloRelatorioController = CompositionRoot.CriarModeloRelatorioController();
            _cadastroModeloRelatorioUserControl = cadastroModeloRelatorioUserControl;
        }

        void FormVisualizaModeloRelatorio_Load(object sender, EventArgs e)
        {
            BuscaTipoModelo();
            CarregaDadosModelo();
        }

        void btnSalvarCadastroModelo_Click(object sender, EventArgs e)
        {
            var dados = new ModeloRelatorioDTO
            {
                Id = _cadastroModeloRelatorioUserControl.IdSelecionado,
                Descricao = txtDescricaoModelo.Text,
                TipoModeloId = (int)comboTipoModelo.EditValue,
                Ativo = checkAtivo.Checked,
                Texto = richEditVisualizaTextoModelo.Document.GetOpenXmlBytes(richEditVisualizaTextoModelo.Document.Range)
            };

            var resposta = _modeloRelatorioController.Edicao(dados);

            if (!string.IsNullOrWhiteSpace(resposta))
            {
                MessageService.Mensagem_Atencao(resposta);
                return;
            }

            this.Close();
        }

        void btnFecharCadastroModelo_Click(object sender, EventArgs e)
            => MessageService.Acao_FecharForm_CancelarExecucao(this, "Deseja realmente fechar a visualização deste modelo? \nAs ações realizadas não serão salvas!");

        void btnAbreEdicaoModelo_Click(object sender, EventArgs e)
        {
            var editaTextoAtividade = new FormEditaTextoAtividade(richEditVisualizaTextoModelo.RtfText);
            editaTextoAtividade.ShowDialog();
            richEditVisualizaTextoModelo.RtfText = editaTextoAtividade.NovoTextoDescricaoAtividade;
        }

        void BuscaTipoModelo()
        {
            var resultadoBusca = _tipoModeloController.PesquisarParaCombo().ToList();

            if (resultadoBusca == null)
                return;

            comboTipoModelo.Properties.DataSource = resultadoBusca;
            comboTipoModelo.Properties.DisplayMember = "Descricao";
            comboTipoModelo.Properties.ValueMember = "Id";
            comboTipoModelo.Properties.NullText = "Selecione um modelo";
        }

        void CarregaDadosModelo()
        {
            var dados = _modeloRelatorioController.PreencheDadosTela(_cadastroModeloRelatorioUserControl.IdSelecionado);

            if (dados == null)
                return;

            txtDescricaoModelo.Text = dados.Descricao;
            comboTipoModelo.EditValue = dados.TipoModeloId;
            checkAtivo.Checked = dados.Ativo;
            richEditVisualizaTextoModelo.LoadDocument(dados.Texto, DocumentFormat.OpenXml);
        }

        void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageService.Mensagem_Pergunta("Deseja realmente excluir este modelo?") == DialogResult.Yes)
            {
                var resposta = _modeloRelatorioController.Exclusao(_cadastroModeloRelatorioUserControl.IdSelecionado);

                if (!string.IsNullOrWhiteSpace(resposta))
                {
                    MessageService.Mensagem_Atencao(resposta);
                    return;
                }                    

                this.Close();
                _cadastroModeloRelatorioUserControl.AtualizaGrid();
            }
        }
    }
}