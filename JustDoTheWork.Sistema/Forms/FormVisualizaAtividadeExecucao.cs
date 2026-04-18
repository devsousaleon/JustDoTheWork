using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.Sistema.Composition;
using JustDoTheWork.Sistema.ControlPanel;
using System;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormVisualizaAtividadeExecucao : XtraForm
    {
        private readonly ExecucaoController _execucaoController;
        private readonly HomeUserControl _homeUserControl;

        public FormVisualizaAtividadeExecucao(HomeUserControl homeUserControl)
        {
            InitializeComponent();
            _execucaoController = CompositionRoot.CriarExecucaoController();
            _homeUserControl = homeUserControl;
        }

        private void FormVisualizaAtividadeExecucao_Load(object sender, EventArgs e)
        {
            CarregaInfoAtividadeExecucao();
        }

        void CarregaInfoAtividadeExecucao()
        {
            var dadosInfoExecucao = _execucaoController.InformaDadosExecucao(_homeUserControl.IdSelecionadoAtividade);            

            if(dadosInfoExecucao != null)
            {
                dataGridHistoricoExecucao.DataSource = dadosInfoExecucao;
                gridHistoricoExecucao.Columns["DataFimExecucao"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridHistoricoExecucao.Columns["DataFimExecucao"].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
                gridHistoricoExecucao.Columns["DataInicioExecucao"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridHistoricoExecucao.Columns["DataInicioExecucao"].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            }

            var dadosInfoAtividade = _execucaoController.InformaDadosAtividade(_homeUserControl.IdSelecionadoAtividade);

            txtEditorAtividade.LoadDocument(dadosInfoAtividade.DescricaoAtividade, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
            txtNomeAtividade.Text = dadosInfoAtividade.NomeAtividade;
            txtNomeProjeto.Text = dadosInfoAtividade.NomeProjeto;
            DataCriacaoAtividade.EditValue = dadosInfoAtividade.DataCriacaoAtividade;
        }
    }
}