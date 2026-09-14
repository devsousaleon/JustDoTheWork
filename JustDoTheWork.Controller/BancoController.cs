using JustDoTheWork.DTO;
using JustDoTheWork.Infrastructure.Repository;

namespace JustDoTheWork.Controller
{
    public class BancoController
    {
        private readonly BancoRepository _bancoRepository;

        public BancoController(BancoRepository repository)
        {
            _bancoRepository = repository;
        }

        public string TestarConexaoSqlServer(BancoDTO conexao)
            => _bancoRepository.TestarConexaoSqlServer(conexao);

        public string TestarConexaoPostgres(BancoDTO conexao)
            => _bancoRepository.TestarConexaoPostgres(conexao);
    }
}
