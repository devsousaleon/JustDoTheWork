using JustDoTheWork.Controller;
using JustDoTheWork.Sistema.Forms;
using System.Configuration;

namespace JustDoTheWork.Sistema
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var databaseConfiguration = ConfigurationManager.ConnectionStrings["SqlServer"] ?? ConfigurationManager.ConnectionStrings["Postgres"];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (databaseConfiguration is null || string.IsNullOrWhiteSpace(databaseConfiguration.ConnectionString))
                Application.Run(new FormConfigBanco());
            else
            {
                CompositionRoot.Configurar(databaseConfiguration.ConnectionString, databaseConfiguration.ProviderName);
                Application.Run(new FormPrincipal());
            }
        }
    }
}
