using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Sistema.Composition;

namespace JustDoTheWork.Sistema.ControlPanel
{
    public partial class HistoricoUserControl : XtraUserControl
    {
        private readonly ProjetoController _projetoController;
        private readonly AtividadeController _atividadeController;

        public HistoricoUserControl()
        {
            InitializeComponent();
            _projetoController = CompositionRoot.CriarProjetoController();
            _atividadeController = CompositionRoot.CriarAtividadeController();
        }

        void HistoricoUserControl_Load(object sender, EventArgs e)
        {
            AtualizaComboBoxProjeto();
            AtualizaComboBoxStatus();
        }

        void AtualizaComboBoxProjeto()
        {
            var dados = _projetoController.PesquisarParaCombo().ToList();

            if (dados == null)
                return;

            comboProjetoPesquisa.Properties.DataSource = dados;
            comboProjetoPesquisa.Properties.DisplayMember = "Nome";
            comboProjetoPesquisa.Properties.ValueMember = "Id";
            comboProjetoPesquisa.Properties.NullText = "Selecione um projeto";
        }

        void AtualizaComboBoxStatus()
        {
            comboStatusPesquisa.Properties.DataSource = _atividadeController.ObterStatusAtividade();

            comboStatusPesquisa.Properties.DisplayMember = "Status";
            comboStatusPesquisa.Properties.ValueMember = "Id";
            comboStatusPesquisa.Properties.NullText = "Selecione uma opção";
        }

        void btnPesquisarHistorico_Click(object sender, EventArgs e)
        {
            var filtroPesquisa = new FiltroPesquisaHistoricoDTO
            {
                ProjetoId = comboProjetoPesquisa.EditValue != null ? (int?)comboProjetoPesquisa.EditValue : null,
                Status = comboStatusPesquisa.EditValue != null ? (int?)comboStatusPesquisa.EditValue : null,
                DataCriacaoAtividade = DataCriacao.EditValue != null ? (DateTime?)DataCriacao.DateTime.Date : null
            };

            var resultadoFiltro = _atividadeController.PesquisarParaGridVisualizaHistorico(filtroPesquisa);

            gridControlHistorico.DataSource = resultadoFiltro;
        }

        void btnLimpar_Click(object sender, EventArgs e)
        {
            comboProjetoPesquisa.EditValue = null;
            comboStatusPesquisa.EditValue = null;
            DataCriacao.EditValue = null;
        }

        void btnImprimirHistorico_Click(object sender, EventArgs e)
        {

        }
    }
}