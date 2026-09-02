using JustDoTheWork.Controller;
using JustDoTheWork.Infrastructure;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using JustDoTheWork.Infrastructure.Repository;

namespace JustDoTheWork.Sistema.Composition
{
    public static class CompositionRoot
    {
        private static DBConnection ConnectionDB()
        {
            return new DBConnection(ConnectionStringResolver.Resolver());
        }

        public static AtividadeController CriarAtividadeController()
        {
            var dbConnection = ConnectionDB();
            IAtividadeRepository repository = new AtividadeRepository(dbConnection);
            IExecucaoRepository execucaoRepository = new ExecucaoRepository(dbConnection);
            IUnitOfWorkFactory uowFactory = new UnitOfWorkFactory(dbConnection);
            return new AtividadeController(repository, execucaoRepository, uowFactory);
        }

        public static ProjetoController CriarProjetoController()
        {
            var dbConnection = ConnectionDB();
            IProjetoRepository repository = new ProjetoRepository(dbConnection);
            return new ProjetoController(repository);
        }

        public static ExecucaoController CriarExecucaoController()
        {
            var dbConnection = ConnectionDB();
            IExecucaoRepository repository = new ExecucaoRepository(dbConnection);
            return new ExecucaoController(repository);
        }

        public static ModeloRelatorioController CriarModeloRelatorioController()
        {
            var dbConnection = ConnectionDB();
            IModeloRelatorioRepository repository = new ModeloRelatorioRepository(dbConnection);
            return new ModeloRelatorioController(repository);
        }

        public static TipoModeloController CriarTipoModeloController()
        {
            var dbConnection = ConnectionDB();
            ITipoModeloRepository repository = new TipoModeloRepository(dbConnection);
            return new TipoModeloController(repository);
        }
    }
}