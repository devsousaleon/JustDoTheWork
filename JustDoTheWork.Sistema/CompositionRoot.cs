using JustDoTheWork.Controller;
using JustDoTheWork.Infrastructure;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using JustDoTheWork.Infrastructure.Repository;
using Npgsql;
using System.Configuration;
using System.Data;

namespace JustDoTheWork.Sistema.Composition
{
    public static class CompositionRoot
    {
        private static DBConnectionFactory CriarFactory()
        {
            var connectionString =
                ConfigurationManager
                    .ConnectionStrings["Postgres"]
                    .ConnectionString;

            return new DBConnectionFactory(connectionString);
        }

        public static AtividadeController CriarAtividadeController()
        {
            var factory = CriarFactory();

            IAtividadeRepository repository =
                new AtividadeRepository(factory);

            return new AtividadeController(repository);
        }

        public static ProjetoController CriarProjetoController()
        {
            var factory = CriarFactory();

            IProjetoRepository repository =
                new ProjetoRepository(factory);

            return new ProjetoController(repository);
        }
        //public static ExecucaoController CriarProjetoController()
        //{
        //    var connection = CriarConexao();

        //    IProjetoRepository repository =
        //        new ExecucaoRepository(connection);

        //    return new ExecucaoController(repository);
        //}
    }
}