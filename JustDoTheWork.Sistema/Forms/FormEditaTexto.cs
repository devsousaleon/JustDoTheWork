using DevExpress.XtraEditors;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormEditaTexto : XtraForm
    {
        private readonly bool _somenteLeitura;
        public string TextoEditado { get; private set; }

        public FormEditaTexto(string textoAtual) : this(textoAtual, false)
        {
        }

        public FormEditaTexto(string textoAtual, bool somenteLeitura)
        {
            InitializeComponent();
            _somenteLeitura = somenteLeitura;
            TextoEditado = textoAtual;

            if (_somenteLeitura)
                ConfiguraModoImpressao();
            else
                ConfiguraCamposObjeto();
        }

        void ConfiguraModoImpressao()
        {
            Text = "Impressão do histórico";
            richEditTexto.ReadOnly = true;
            groupCamposObjeto.Visible = false;
            btnSalvarTexto.Visible = false;
            btnImprimirTexto.Visible = true;
            btnFecharEdicaoTexto.Text = "Fechar";

            foreach (DevExpress.XtraBars.Bar barra in barManager.Bars)
                barra.Visible = false;

            richEditTexto.Bounds = Rectangle.FromLTRB(panelAcoes.Left, 12, panelAcoes.Right, panelAcoes.Top - 15);
        }

        void ConfiguraCamposObjeto()
        {
            ConfiguraCampoObjeto(comboCampoAtividade, nameof(Atividade),
                (nameof(Atividade.Id), "ID"),
                (nameof(Atividade.Nome), "Nome"),
                (nameof(Atividade.Descricao), "Descrição"),
                (nameof(Atividade.Status), "Status"),
                (nameof(Atividade.DataCriacao), "Data de criação"),
                (nameof(Atividade.DataFinalizacao), "Data de finalização"),
                (nameof(Atividade.ProjetoId), "ID do projeto"));

            ConfiguraCampoObjeto(comboCampoExecucao, nameof(Execucao),
                (nameof(Execucao.Id), "ID"),
                (nameof(Execucao.DataInicio), "Data de início"),
                (nameof(Execucao.DataFim), "Data de fim"),
                (nameof(Execucao.AtividadeId), "ID da atividade"));

            ConfiguraCampoObjeto(comboCampoProjeto, nameof(Projeto),
                (nameof(Projeto.Id), "ID"),
                (nameof(Projeto.Nome), "Nome"));

            ConfiguraCampoObjeto(comboCampoModeloRelatorio, nameof(ModeloRelatorio),
                (nameof(ModeloRelatorio.Id), "ID"),
                (nameof(ModeloRelatorio.Descricao), "Descrição"),
                (nameof(ModeloRelatorio.TipoModeloId), "ID do tipo de modelo"),
                (nameof(ModeloRelatorio.Texto), "Texto"),
                (nameof(ModeloRelatorio.Ativo), "Ativo"));

            ConfiguraCampoObjeto(comboCampoTipoModelo, nameof(TipoModelo),
                (nameof(TipoModelo.Id), "ID"),
                (nameof(TipoModelo.Descricao), "Descrição"));

            ConfiguraCampoObjeto(comboCampoUsuario, nameof(Usuario),
                (nameof(Usuario.Id), "ID"),
                (nameof(Usuario.Nome), "Nome"),
                (nameof(Usuario.Logon), "Logon"),
                (nameof(Usuario.TipoUsuarioId), "ID do tipo de usuário"));

            ConfiguraCampoObjeto(comboCampoTipoUsuario, nameof(TipoUsuario),
                (nameof(TipoUsuario.Id), "ID"),
                (nameof(TipoUsuario.Tipo), "Tipo"));

            ConfiguraCampoObjeto(comboCampoComum, "Comum",
                ("Data", "Data"),
                ("Hora", "Hora"),
                ("DataHora", "Data e hora"),
                ("DataPorExtenso", "Data por extenso"),
                ("DiaDaSemana", "Dia da semana"));
        }

        void ConfiguraCampoObjeto(ComboBoxEdit combo, string tabela, params (string Nome, string Descricao)[] campos)
        {
            combo.Properties.Items.AddRange(campos
                .Select(campo => new CampoObjeto($"{tabela}.{campo.Nome}", campo.Descricao))
                .ToArray());
        }

        void comboCampoObjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_somenteLeitura || sender is not ComboBoxEdit combo || combo.SelectedItem is not CampoObjeto campoObjeto)
                return;

            var selecao = richEditTexto.Document.Selection;
            var documento = selecao.BeginUpdateDocument();

            try
            {
                var posicao = selecao.Start;
                documento.Delete(selecao);
                var campo = documento.Fields.Create(posicao, $"MERGEFIELD \"{campoObjeto.Codigo}\"");
                campo.Update();
                richEditTexto.Document.CaretPosition = campo.Range.End;
            }
            finally
            {
                selecao.EndUpdateDocument(documento);
                combo.SelectedIndex = -1;
            }

            richEditTexto.Focus();
        }

        private sealed record CampoObjeto(string Codigo, string Descricao)
        {
            public override string ToString() => Descricao;
        }

        void btnSalvarTexto_Click(object sender, EventArgs e)
        {
            if (_somenteLeitura)
                return;

            TextoEditado = richEditTexto.RtfText;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        void btnFecharEdicaoTexto_Click(object sender, EventArgs e)
        {
            if (_somenteLeitura)
                Close();
            else
                MessageService.Cancelar(this, "Deseja realmente fechar a edição do texto da atividade? \nAs ações realizadas não serão salvas e serão perdidas!");
        }

        void btnImprimirTexto_Click(object sender, EventArgs e)
        {
            if (!_somenteLeitura)
                return;

            try
            {
                richEditTexto.ShowPrintDialog();
            }
            catch (Exception)
            {
                MessageService.Atencao("Não foi possível abrir a impressão. Verifique a configuração da impressora e tente novamente.");
            }
        }
        
        void FormEditaTexto_Load(object sender, EventArgs e)
            => richEditTexto.RtfText = TextoEditado ?? "";
    }
}
