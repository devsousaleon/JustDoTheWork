using JustDoTheWork.Controller;
using JustDoTheWork.Sistema.Forms;

namespace JustDoTheWork.Sistema
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlServer"]?.ConnectionString;

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new System.Configuration.ConfigurationErrorsException("A connection string 'SqlServer' não foi encontrada no App.config.");

            CompositionRoot.Configurar(connectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}