using System.Configuration;

namespace JustDoTheWork.Infrastructure
{
    public static class ConnectionStringResolver
    {
        public const string VariavelAmbiente = "JUSTDOTHEWORK_SQLSERVER";

        public static string Resolver()
        {
            var ambiente = Environment.GetEnvironmentVariable(VariavelAmbiente);
            if (!string.IsNullOrWhiteSpace(ambiente))
                return ambiente;

            var configurada = ConfigurationManager.ConnectionStrings["SqlServer"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(configurada))
                throw new InvalidOperationException(
                    $"Defina a variável de ambiente {VariavelAmbiente} ou a connection string SqlServer em App.config.");

            return configurada;
        }
    }
}
