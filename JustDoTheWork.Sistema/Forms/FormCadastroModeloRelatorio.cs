using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.UI.Core;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormCadastroModeloRelatorio : XtraForm
    {
        private readonly TipoModeloController _tipoModeloController;
        private readonly ModeloRelatorioController _modeloRelatorioController;

        public FormCadastroModeloRelatorio()
        {
            InitializeComponent();
            _tipoModeloController = CompositionRoot.CriarTipoModeloController();
            _modeloRelatorioController = CompositionRoot.CriarModeloRelatorioController();
        }
        void FormCadastroModeloRelatorio_Load(object sender, EventArgs e)
            => BuscaTipoModelo();

        void btnIncluirCadastroModelo_Click(object sender, EventArgs e)
        {
            var dados = new ModeloRelatorioDTO
            {
                TipoModeloId = (int)comboTipoModelo.EditValue,
                Descricao = txtDescricaoModelo.Text,
                Ativo = checkAtivo.Checked,
                Texto = richEditVisualizaTextoModelo.Document.GetOpenXmlBytes(richEditVisualizaTextoModelo.Document.Range)
            };

            var resposta = _modeloRelatorioController.Inclusao(dados);

            if (!string.IsNullOrWhiteSpace(resposta))
            {
                MessageService.Mensagem_Atencao(resposta);
                return;
            }

            this.Close();
        }

        void btnFecharCadastroModelo_Click(object sender, EventArgs e)
            => MessageService.Acao_FecharForm_CancelarExecucao(this, "Deseja realmente fechar o cadastro deste modelo? \nAs ações realizadas não serão salvas!");

        void btnAbreEdicaoModelo_Click(object sender, EventArgs e)
        {
            var editaTextoAtividade = new FormEditaTextoAtividade(richEditVisualizaTextoModelo.RtfText);
            editaTextoAtividade.ShowDialog();
            richEditVisualizaTextoModelo.RtfText = editaTextoAtividade.NovoTextoDescricaoAtividade;
        }

        void BuscaTipoModelo()
            => UIMethodsService.AtualizaComboBoxTipoModelo(_tipoModeloController, comboTipoModelo);
    }
}