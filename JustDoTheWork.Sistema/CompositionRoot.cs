using JustDoTheWork.Controller;
using JustDoTheWork.Infrastructure;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using JustDoTheWork.Infrastructure.Repository;
using System.Configuration;

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
            IAtividadeRepository repository = new AtividadeRepository(factory);
            return new AtividadeController(repository);
        }

        public static ProjetoController CriarProjetoController()
        {
            var factory = CriarFactory();
            IProjetoRepository repository = new ProjetoRepository(factory);
            return new ProjetoController(repository);
        }

        public static ExecucaoController CriarExecucaoController()
        {
            var factory = CriarFactory();
            IExecucaoRepository repository = new ExecucaoRepository(factory);
            return new ExecucaoController(repository);
        }
    }
}