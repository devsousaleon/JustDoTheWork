using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.ControlPanel;
using JustDoTheWork.UI.Core;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormVisualizaModeloRelatorio : XtraForm
    {
        private readonly TipoModeloController _tipoModeloController;
        private readonly ModeloRelatorioController _modeloRelatorioController;
        private readonly CadastroModeloRelatorioUserControl _cadastroModeloRelatorioUserControl;
        private string _revisao = string.Empty;
        private byte[] _textoOriginal;
        private bool _textoEditado;

        public FormVisualizaModeloRelatorio(CadastroModeloRelatorioUserControl cadastroModeloRelatorioUserControl)
        {
            InitializeComponent();
            _tipoModeloController = CompositionRoot.CriarTipoModeloController();
            _modeloRelatorioController = CompositionRoot.CriarModeloRelatorioController();
            _cadastroModeloRelatorioUserControl = cadastroModeloRelatorioUserControl;
        }

        void FormVisualizaModeloRelatorio_Load(object sender, EventArgs e)
        {
            AtualizaComboBoxTipoModelo();
            CarregaDadosModelo();
        }

        void btnSalvarCadastroModeloRelatorio_Click(object sender, EventArgs e)
        {
            var modeloRelatorioDTO = new ModeloRelatorioDTO
            {
                Id = _cadastroModeloRelatorioUserControl.IdSelecionado,
                Revisao = _revisao,
                Descricao = txtDescricaoModelo.Text,
                TipoModeloId = (int)comboTipoModelo.EditValue,
                Ativo = checkAtivo.Checked,
                Texto = _textoEditado ? richEditTextoModelo.Document.GetOpenXmlBytes(richEditTextoModelo.Document.Range) : _textoOriginal
            };

            var mensagemRetornoCadastroModeloRelatorio = _modeloRelatorioController.Edicao(modeloRelatorioDTO);

            if (!string.IsNullOrWhiteSpace(mensagemRetornoCadastroModeloRelatorio))
            {
                MessageService.Atencao(mensagemRetornoCadastroModeloRelatorio);
                return;
            }

            this.Close();
        }

        void btnFecharCadastroModeloRelatorio_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar a visualização deste modelo? \nAs ações realizadas não serão salvas!");

        void btnEditarTextoModelo_Click(object sender, EventArgs e)
        {
            FormEditaTexto formEditaTexto = new FormEditaTexto(richEditTextoModelo.RtfText);
            if (formEditaTexto.ShowDialog(this) == DialogResult.OK)
            {
                richEditTextoModelo.RtfText = formEditaTexto.TextoEditado;
                _textoEditado = true;
            }
        }

        void AtualizaComboBoxTipoModelo()
            => UIMethodsService.AtualizaComboBoxTipoModelo(_tipoModeloController, comboTipoModelo);

        void CarregaDadosModelo()
        {
            var modeloRelatorioDTO = _modeloRelatorioController.BuscarPorId(_cadastroModeloRelatorioUserControl.IdSelecionado);

            if (modeloRelatorioDTO == null)
                return;
            _revisao = modeloRelatorioDTO.Revisao;
            _textoOriginal = modeloRelatorioDTO.Texto;
            _textoEditado = false;

            txtDescricaoModelo.Text = modeloRelatorioDTO.Descricao;
            comboTipoModelo.EditValue = modeloRelatorioDTO.TipoModeloId;
            checkAtivo.Checked = modeloRelatorioDTO.Ativo;

            if (modeloRelatorioDTO.Texto is { Length: > 0 })
                richEditTextoModelo.LoadDocument(modeloRelatorioDTO.Texto, DocumentFormat.OpenXml);
            else
                richEditTextoModelo.CreateNewDocument();
        }

        void btnExcluirModeloRelatorio_Click(object sender, EventArgs e)
        {
            if (MessageService.Pergunta("Deseja realmente excluir este modelo?") == DialogResult.Yes)
            {
                var mensagemRetornoExclusaoModeloRelatorio = _modeloRelatorioController.Exclusao(_cadastroModeloRelatorioUserControl.IdSelecionado, _revisao);

                if (!string.IsNullOrWhiteSpace(mensagemRetornoExclusaoModeloRelatorio))
                {
                    MessageService.Atencao(mensagemRetornoExclusaoModeloRelatorio);
                    return;
                }                    

                this.Close();
                _cadastroModeloRelatorioUserControl.AtualizaGrid();
            }
        }
    }
}
