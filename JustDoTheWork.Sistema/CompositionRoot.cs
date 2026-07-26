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
            //var connectionStringPostgres = ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString;
            var connectionStringSqlServer = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
            return new DBConnection(connectionStringSqlServer);
        }
        public static AtividadeController CriarAtividadeController()
        {
            var _dbconnection = ConnectionDB();
            IAtividadeRepository repository = new AtividadeRepository(_dbconnection);
            return new AtividadeController(repository);
        }
        public static ProjetoController CriarProjetoController()
        {
            var _dbconnection = ConnectionDB();
            IProjetoRepository repository = new ProjetoRepository(_dbconnection);
            return new ProjetoController(repository);
        }
        public static ExecucaoController CriarExecucaoController()
        {
            var _dbconnection = ConnectionDB();
            IExecucaoRepository repository = new ExecucaoRepository(_dbconnection);
            return new ExecucaoController(repository);
        }
    }
}