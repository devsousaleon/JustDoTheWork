using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.UI.Core.Geral;
using System.Configuration;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormConfigBanco : XtraForm
    {
        private readonly BancoController _bancoController;

        public FormConfigBanco()
        {
            InitializeComponent();
            _bancoController = CompositionRoot.CriarBancoController();
            bindingSourceBancoDTO.DataSource = new BancoDTO();
        }

        void FormConfigBanco_Load(object sender, EventArgs e)
        {
            txtServidor.Enabled = false;
            txtBanco.Enabled = false;
            txtSenhaBanco.Enabled = false;
            txtUsuarioBanco.Enabled = false;
        }

        void btnSalvarConfigBanco_Click(object sender, EventArgs e)
        {
            string mensagem = ValidarDados();

            if (mensagem != "")
            {
                MessageService.Mensagem_Atencao(mensagem);
                return;
            }
            
            string nomeConnectionString = comboBoxEditTipoBanco.SelectedIndex == 0 ? "SqlServer" : "Postgres";
            string connectionString = CriaConnectionString();
            string providerName = comboBoxEditTipoBanco.SelectedIndex == 0 ? "Microsoft.Data.SqlClient" : "Npgsql";

            mensagem = TestarConexao();

            if (mensagem != "")
            {
                MessageService.Mensagem_Atencao(mensagem);
                return;
            }

            SalvarConnectionString(nomeConnectionString, connectionString, providerName);

            MessageService.Mensagem_Sucesso("Configuração realizada corretamente!\nO Sistema será encerrado e poderá ser iniciado novamente já configurado.");
            Application.Exit();
        }

        string CriaConnectionString()
        {
            if (comboBoxEditTipoBanco.SelectedIndex == 0)
            {
                return $"Server={txtServidor.Text};" +
                       $"Database={txtBanco.Text};" +
                       $"User Id={txtUsuarioBanco.Text};" +
                       $"Password={txtSenhaBanco.Text};" +
                       $"TrustServerCertificate=True";
            }
            else if (comboBoxEditTipoBanco.SelectedIndex == 1)
            {
                return $"Host={txtServidor.Text};" +
                       $"Database={txtBanco.Text};" +
                       $"Username={txtUsuarioBanco.Text};" +
                       $"Password={txtSenhaBanco.Text};";
            }
            else
                return "Não há banco selecionado para criação da connectionString!";
        }

        void comboBoxEditTipoBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool componenteAtivado = comboBoxEditTipoBanco.SelectedIndex != -1;

            txtServidor.Enabled = componenteAtivado;
            txtBanco.Enabled = componenteAtivado;
            txtSenhaBanco.Enabled = componenteAtivado;
            txtUsuarioBanco.Enabled = componenteAtivado;
        }

        void comboBoxEditTipoBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                comboBoxEditTipoBanco.SelectedIndex = -1;
        }

        void btnCancelar_Click(object sender, EventArgs e)
            => MessageService.Acao_FecharForm_CancelarExecucao(this, "Deseja realmente cancelar esta configuração?\nNenhuma informação não salva será perdida e precisará ser configurada novamente.");

        string ValidarDados()
        {
            if (comboBoxEditTipoBanco.SelectedIndex == -1)
                return "Necessário informar o tipo do banco de dados!";

            if (string.IsNullOrWhiteSpace(txtServidor.Text))
                return "Necessário informar o nome do servidor!";

            if (string.IsNullOrWhiteSpace(txtBanco.Text))
                return "Necessário informar o banco de dados!";

            if (string.IsNullOrWhiteSpace(txtUsuarioBanco.Text))
                return "Necessário informar o usuário para acesso ao banco!";

            if (string.IsNullOrWhiteSpace(txtSenhaBanco.Text))
                return "Necessário informar a senha para acesso ao banco!";

            return "";
        }

        string TestarConexao()
        {
            var dtoBanco = bindingSourceBancoDTO.Current as BancoDTO;

            if (comboBoxEditTipoBanco.SelectedIndex == 0)
                return _bancoController.TestarConexaoSqlServer(dtoBanco);
            else if (comboBoxEditTipoBanco.SelectedIndex == 1)
                return _bancoController.TestarConexaoPostgres(dtoBanco);
            else
                return "Erro ao tentar testar conexão!";
        }

        void SalvarConnectionString(string nome, string connectionString, string providerName)
        {
            var configurationManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = configurationManager.ConnectionStrings;
            var connectionStrings = connectionStringsSection.ConnectionStrings;

            connectionStrings.Remove("SqlServer");
            connectionStrings.Remove("Postgres");

            var settings = new ConnectionStringSettings(nome, connectionString, providerName);

            connectionStrings.Add(settings);

            if (!connectionStringsSection.SectionInformation.IsProtected)
                connectionStringsSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");

            connectionStringsSection.SectionInformation.ForceSave = true;

            configurationManager.Save(ConfigurationSaveMode.Modified);
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            string mensagem = TestarConexao();

            if (mensagem != "")
                MessageService.Mensagem_Erro(mensagem);
            else
                MessageService.Mensagem_Sucesso("Conexão estabelecida com sucesso!");
        }
    }
}
