using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class UsuarioController
    {
        private readonly IUsuarioRepository _iUsuarioRepository;
        string mensagem;

        public UsuarioController(IUsuarioRepository repository)
        {
            _iUsuarioRepository = repository;
        }

        public IEnumerable<TipoUsuario> ObterTiposUsuario()
        {
            var tiposUsuario = new[] { "Historiador", "Desenvolvedor", "QA Tester", "Tech Lead" };

            return _iUsuarioRepository.BuscarTiposUsuario()
                .Where(tipo => tiposUsuario.Contains(tipo.Tipo, StringComparer.OrdinalIgnoreCase))
                .OrderBy(tipo => Array.FindIndex(tiposUsuario, nome => string.Equals(nome, tipo.Tipo, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }

        public IEnumerable<ResultadoPesquisaUsuarioDTO> PesquisaUsuario(FiltroPesquisaUsuarioDTO filtro)
            => _iUsuarioRepository.Pesquisar(filtro);

        public UsuarioDTO? BuscaUsuarioPorId(int id)
        {
            var usuario = _iUsuarioRepository.BuscarPorId(id);

            if (usuario is null)
                return null;

            return new UsuarioDTO
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Logon = usuario.Logon,
                Senha = usuario.Senha,
                TipoUsuarioId = usuario.TipoUsuarioId
            };
        }

        public string Inclusao(UsuarioDTO usuarioDTO)
        {
            if (string.IsNullOrWhiteSpace(usuarioDTO.Nome))
                return "Necessário informar o nome do usuário!";

            if (string.IsNullOrWhiteSpace(usuarioDTO.Logon))
                return "Necessário informar o nome para login!";

            if (string.IsNullOrWhiteSpace(usuarioDTO.Senha))
                return "Necessário informar a senha!";

            if (usuarioDTO.TipoUsuarioId == 0)
                return "Necessário informar o tipo de usuário!";

            var usuario = new Usuario
            {
                Nome = usuarioDTO.Nome,
                Logon = usuarioDTO.Logon,
                Senha = usuarioDTO.Senha,
                TipoUsuarioId = usuarioDTO.TipoUsuarioId
            };
            mensagem = _iUsuarioRepository.Inclusao(usuario);

            return mensagem;
        }

        public string Edicao(UsuarioDTO usuarioDTO)
        {
            if (string.IsNullOrWhiteSpace(usuarioDTO.Nome))
                return "Necessário informar o nome do usuário!";

            if (string.IsNullOrWhiteSpace(usuarioDTO.Logon))
                return "Necessário informar o nome para login!";

            if (usuarioDTO.TipoUsuarioId == 0)
                return "Necessário informar o tipo de usuário!";

            var usuario = new Usuario
            {
                Id = usuarioDTO.Id,
                Nome = usuarioDTO.Nome,
                Logon = usuarioDTO.Logon,
                Senha = usuarioDTO.Senha,
                TipoUsuarioId = usuarioDTO.TipoUsuarioId
            };

            return _iUsuarioRepository.Edicao(usuario);
        }

        public string Exclusao(int idExclusao)
            => _iUsuarioRepository.ExclusaoPorId(idExclusao);

        public UsuarioDTO BuscaUsuarioPorLogon(string logon)
        {
            var usuario = _iUsuarioRepository.BuscarPorLogon(logon);

            if (usuario is null)
                return null;

            var us = new UsuarioDTO
            {
                Id = usuario.Id,
                Logon = usuario.Logon,
                Senha = usuario.Senha,
                Nome = usuario.Nome,
                TipoUsuarioId = usuario.TipoUsuarioId
            };

            return us;
        }
    }
}
