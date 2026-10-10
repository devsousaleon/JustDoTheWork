using DevExpress.XtraEditors;
using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.UI.Core.Geral;
using System.Configuration;

namespace JustDoTheWork.Sistema.Forms
{
    public partial class FormConfiguracaoBanco : XtraForm
    {
        private readonly BancoController _bancoController;

        public FormConfiguracaoBanco()
        {
            InitializeComponent();
            _bancoController = CompositionRoot.CriarBancoController();
            bindingSourceBanco.DataSource = new BancoDTO();
        }

        void FormConfiguracaoBanco_Load(object sender, EventArgs e)
        {
            txtServidor.Enabled = false;
            txtBanco.Enabled = false;
            txtSenhaBanco.Enabled = false;
            txtUsuarioBanco.Enabled = false;
        }

        void btnSalvarConfiguracaoBanco_Click(object sender, EventArgs e)
        {
            string mensagem = ValidarDados();

            if (mensagem != "")
            {
                MessageService.Atencao(mensagem);
                return;
            }
            
            string nomeConnectionString = comboTipoBanco.SelectedIndex == 0 ? "SqlServer" : "Postgres";
            string connectionString = CriaConnectionString();
            string providerName = comboTipoBanco.SelectedIndex == 0 ? "Microsoft.Data.SqlClient" : "Npgsql";

            mensagem = TestarConexao();

            if (mensagem != "")
            {
                MessageService.Atencao(mensagem);
                return;
            }

            SalvarConnectionString(nomeConnectionString, connectionString, providerName);

            MessageService.Sucesso("Configuração realizada corretamente!\nO Sistema será encerrado e poderá ser iniciado novamente já configurado.");
            Application.Exit();
        }

        string CriaConnectionString()
        {
            if (comboTipoBanco.SelectedIndex == 0)
            {
                return $"Server={txtServidor.Text};" +
                       $"Database={txtBanco.Text};" +
                       $"User Id={txtUsuarioBanco.Text};" +
                       $"Password={txtSenhaBanco.Text};" +
                       $"TrustServerCertificate=True";
            }
            else if (comboTipoBanco.SelectedIndex == 1)
            {
                return $"Host={txtServidor.Text};" +
                       $"Database={txtBanco.Text};" +
                       $"Username={txtUsuarioBanco.Text};" +
                       $"Password={txtSenhaBanco.Text};";
            }
            else
                return "Não há banco selecionado para criação da connectionString!";
        }

        void comboTipoBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool componenteAtivado = comboTipoBanco.SelectedIndex != -1;

            txtServidor.Enabled = componenteAtivado;
            txtBanco.Enabled = componenteAtivado;
            txtSenhaBanco.Enabled = componenteAtivado;
            txtUsuarioBanco.Enabled = componenteAtivado;
        }

        void comboTipoBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                comboTipoBanco.SelectedIndex = -1;
        }

        void btnFecharConfiguracaoBanco_Click(object sender, EventArgs e)
            => MessageService.Cancelar(this, "Deseja realmente cancelar esta configuração?\nNenhuma informação não salva será perdida e precisará ser configurada novamente.");

        string ValidarDados()
        {
            if (comboTipoBanco.SelectedIndex == -1)
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
            var bancoDTO = bindingSourceBanco.Current as BancoDTO;

            if (comboTipoBanco.SelectedIndex == 0)
                return _bancoController.TestarConexaoSqlServer(bancoDTO);
            else if (comboTipoBanco.SelectedIndex == 1)
                return _bancoController.TestarConexaoPostgres(bancoDTO);
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
                MessageService.Erro(mensagem);
            else
                MessageService.Sucesso("Conexão estabelecida com sucesso!");
        }
    }
}
