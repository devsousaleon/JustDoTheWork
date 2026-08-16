using JustDoTheWork.Infrastructure;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using JustDoTheWork.Infrastructure.Repository;

namespace JustDoTheWork.Controller
{
    public static class CompositionRoot
    {
        private static DBConnection? _dbConnection;

        public static void Configurar(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("A connection string não pode ser vazia.", nameof(connectionString));

            _dbConnection = new DBConnection(connectionString);
        }

        private static DBConnection ConnectionDB()
            => _dbConnection ?? throw new InvalidOperationException("O CompositionRoot precisa ser configurado antes da criação dos controllers.");

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
        public static ModeloRelatorioController CriarModeloRelatorioController()
        {
            var _dbconnection = ConnectionDB();
            IModeloRelatorioRepository repository = new ModeloRelatorioRepository(_dbconnection);
            return new ModeloRelatorioController(repository);
        }

        public static TipoModeloController CriarTipoModeloController()
        {
            var _dbconnection = ConnectionDB();
            ITipoModeloRepository repository = new TipoModeloRepository(_dbconnection);
            return new TipoModeloController(repository);
        }
    }
}