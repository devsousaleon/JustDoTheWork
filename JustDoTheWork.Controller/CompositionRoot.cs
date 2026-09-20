using JustDoTheWork.Infrastructure;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using JustDoTheWork.Infrastructure.Repository;

namespace JustDoTheWork.Controller
{
    public static class CompositionRoot
    {
        private static JustDoTheWorkDbContextFactory? _dbContextFactory;

        public static void Configurar(string connectionString, string providerName)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("A connection string não pode ser vazia.", nameof(connectionString));

            _dbContextFactory = new JustDoTheWorkDbContextFactory(connectionString, providerName);
        }

        private static JustDoTheWorkDbContextFactory DbContextFactory()
            => _dbContextFactory ?? throw new InvalidOperationException("O CompositionRoot precisa ser configurado antes da criação dos controllers.");

        public static AtividadeController CriarAtividadeController()
        {
            IAtividadeRepository repository = new AtividadeRepository(DbContextFactory());
            return new AtividadeController(repository, _dbContextFactory);
        }
        public static ProjetoController CriarProjetoController()
        {
            IProjetoRepository repository = new ProjetoRepository(_dbContextFactory);
            return new ProjetoController(repository);
        }
        public static ExecucaoController CriarExecucaoController()
        {
            IExecucaoRepository repository = new ExecucaoRepository(DbContextFactory());
            return new ExecucaoController(repository);
        }
        public static ModeloRelatorioController CriarModeloRelatorioController()
        {
            IModeloRelatorioRepository repository = new ModeloRelatorioRepository(_dbContextFactory);
            return new ModeloRelatorioController(repository);
        }
        public static TipoModeloController CriarTipoModeloController()
        {
            ITipoModeloRepository repository = new TipoModeloRepository(_dbContextFactory);
            return new TipoModeloController(repository);
        }
        public static BancoController CriarBancoController()
        {
            var repository = new BancoRepository();
            return new BancoController(repository);
        }
    }
}
