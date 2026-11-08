using JustDoTheWork.Infrastructure;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using JustDoTheWork.Infrastructure.Repository;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;

namespace JustDoTheWork.Controller
{
    public static class CompositionRoot
    {
        private static JustDoTheWorkDbContextFactory? _dbContextFactory;
        public static UsuarioSessaoDTO? UsuarioAtual { get; private set; }
        private static readonly object _sincronizacaoEstrutura = new();
        private static bool _estruturaPreparada;

        public static void Configurar(string connectionString, string providerName)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("A connection string não pode ser vazia.", nameof(connectionString));

            _dbContextFactory = new JustDoTheWorkDbContextFactory(connectionString, providerName);
            UsuarioAtual = null;
            _estruturaPreparada = false;
        }

        public static void IniciarSessao(UsuarioLoginDTO usuario)
        {
            if (usuario.Id <= 0 || !FluxoAtividade.TipoUsuarioValido(usuario.TipoUsuario))
                throw new InvalidOperationException("O usuário precisa possuir um tipo válido para acessar o sistema.");

            UsuarioAtual = new UsuarioSessaoDTO
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                TipoUsuarioId = usuario.TipoUsuarioId,
                TipoUsuario = usuario.TipoUsuario
            };
        }

        private static JustDoTheWorkDbContextFactory DbContextFactory()
            => _dbContextFactory ?? throw new InvalidOperationException("O CompositionRoot precisa ser configurado antes da criação dos controllers.");

        public static void PrepararConsultas()
        {
            using var context = DbContextFactory().CreateDbContext();
            _ = context.Model;
        }

        public static void AtualizarEstruturaAtividades()
        {
            lock (_sincronizacaoEstrutura)
            {
                if (_estruturaPreparada)
                    return;
                new BancoRepository().AtualizarEstruturaAtividades(DbContextFactory());
                _estruturaPreparada = true;
            }
        }

        public static AtividadeController CriarAtividadeController()
        {
            IAtividadeRepository repository = new AtividadeRepository(DbContextFactory(), UsuarioAtual);
            return new AtividadeController(repository, DbContextFactory(), UsuarioAtual);
        }
        public static ProjetoController CriarProjetoController()
        {
            IProjetoRepository repository = new ProjetoRepository(DbContextFactory(), UsuarioAtual);
            return new ProjetoController(repository);
        }
        public static ExecucaoController CriarExecucaoController()
        {
            IExecucaoRepository repository = new ExecucaoRepository(DbContextFactory(), UsuarioAtual);
            return new ExecucaoController(repository);
        }
        public static ModeloRelatorioController CriarModeloRelatorioController()
        {
            IModeloRelatorioRepository repository = new ModeloRelatorioRepository(DbContextFactory(), UsuarioAtual);
            return new ModeloRelatorioController(repository);
        }
        public static TipoModeloController CriarTipoModeloController()
        {
            ITipoModeloRepository repository = new TipoModeloRepository(DbContextFactory(), UsuarioAtual);
            return new TipoModeloController(repository);
        }
        public static BancoController CriarBancoController()
        {
            var repository = new BancoRepository();
            return new BancoController(repository);
        }
        public static UsuarioController CriarUsuarioController()
        {
            IUsuarioRepository repository = new UsuarioRepository(DbContextFactory(), UsuarioAtual);
            return new UsuarioController(repository, UsuarioAtual);
        }
    }
}
