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
            => AtualizaComboBoxTipoModelo();

        void btnSalvarCadastroModeloRelatorio_Click(object sender, EventArgs e)
        {
            var modeloRelatorioDTO = new ModeloRelatorioDTO
            {
                TipoModeloId = (int)comboTipoModelo.EditValue,
                Descricao = txtDescricaoModelo.Text,
                Ativo = checkAtivo.Checked,
                Texto = richEditTextoModelo.Document.GetOpenXmlBytes(richEditTextoModelo.Document.Range)
            };

            var mensagemRetornoCadastroModeloRelatorio = _modeloRelatorioController.Inclusao(modeloRelatorioDTO);

            if (!string.IsNullOrWhiteSpace(mensagemRetornoCadastroModeloRelatorio))
            {
                MessageService.Atencao(mensagemRetornoCadastroModeloRelatorio);
                return;
            }

            this.Close();
        }

        void btnFecharCadastroModeloRelatorio_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente fechar o cadastro deste modelo? \nAs ações realizadas não serão salvas!");

        void btnEditarTextoModelo_Click(object sender, EventArgs e)
        {
            FormEditaTexto formEditaTexto = new FormEditaTexto(richEditTextoModelo.RtfText);
            formEditaTexto.ShowDialog();
            richEditTextoModelo.RtfText = formEditaTexto.TextoEditado;
        }

        void AtualizaComboBoxTipoModelo()
            => UIMethodsService.AtualizaComboBoxTipoModelo(_tipoModeloController, comboTipoModelo);
    }
}
