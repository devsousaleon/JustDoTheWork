using JustDoTheWork.Controller;
using JustDoTheWork.Infrastructure;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using JustDoTheWork.Infrastructure.Repository;
using System.Configuration;

namespace JustDoTheWork.Sistema.Composition
{
    public static class CompositionRoot
    {
        private static DBConnection ConnectionDB()
        {
            var connectionString =
                ConfigurationManager
                    .ConnectionStrings["Postgres"]
                    .ConnectionString;

            return new DBConnection(connectionString);
        }
        public static AtividadeController CriarAtividadeController()
        {
            var _dbconnection = ConnectionDB();
            IAtividadeRepository repository = new AtividadeRepository(_dbconnection);
            return new AtividadeController(repository);
        }
        public static ProjetoController CriarProjetoController()
        {
            var factory = ConnectionDB();
            IProjetoRepository repository = new ProjetoRepository(factory);
            return new ProjetoController(repository);
        }
        public static ExecucaoController CriarExecucaoController()
        {
            var factory = ConnectionDB();
            IExecucaoRepository repository = new ExecucaoRepository(factory);
            return new ExecucaoController(repository);
        }
    }
}