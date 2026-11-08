using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System.Text;

namespace JustDoTheWork.Controller
{
    public class UsuarioController
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly UsuarioSessaoDTO? _usuario;
        string _mensagem;

        public UsuarioController(IUsuarioRepository repository, UsuarioSessaoDTO? usuario = null)
        {
            _usuarioRepository = repository;
            _usuario = usuario;
        }

        public IEnumerable<TipoUsuario> ObterTiposUsuario()
            => _usuarioRepository.BuscarTiposUsuario();

        public UsuarioLoginDTO? BuscarParaLogin(string logon)
            => _usuarioRepository.BuscarParaLogin(logon);

        public IEnumerable<UsuarioSelecaoDTO> PesquisarPorTipo(string tipoUsuario)
            => _usuarioRepository.PesquisarPorTipo(tipoUsuario);

        public IEnumerable<ResultadoPesquisaUsuarioDTO> Pesquisar(FiltroPesquisaUsuarioDTO filtro)
            => _usuarioRepository.Pesquisar(filtro);

        public UsuarioDTO? BuscarPorId(int id)
            => _usuarioRepository.BuscarPorId(id);

        public string Inclusao(UsuarioDTO usuarioDTO)
        {
            if (_usuario?.EhTechLead != true)
                return "Somente o Tech Lead pode cadastrar usuários.";
            if (string.IsNullOrWhiteSpace(usuarioDTO.Nome))
                return "Necessário informar o nome do usuário!";

            if (string.IsNullOrWhiteSpace(usuarioDTO.Logon))
                return "Necessário informar o nome para login!";

            if (string.IsNullOrWhiteSpace(usuarioDTO.Senha))
                return "Necessário informar a senha!";

            if (usuarioDTO.TipoUsuarioId == 0)
                return "Necessário informar o tipo de usuário!";
            if (usuarioDTO.Nome.Length > 30 || usuarioDTO.Logon.Length > 30)
                return "Nome e logon devem ter até 30 caracteres.";
            if (Encoding.UTF8.GetByteCount(usuarioDTO.Senha) > 72)
                return "A senha excede o limite de 72 bytes.";

            var usuario = new Usuario
            {
                Nome = usuarioDTO.Nome.Trim(),
                Logon = usuarioDTO.Logon.Trim(),
                Senha = BCrypt.Net.BCrypt.HashPassword(usuarioDTO.Senha, workFactor: 12),
                TipoUsuarioId = usuarioDTO.TipoUsuarioId
            };
            _mensagem = _usuarioRepository.Inclusao(usuario);

            return _mensagem;
        }

        public string Edicao(UsuarioDTO usuarioDTO)
        {
            if (_usuario?.EhTechLead != true)
                return "Somente o Tech Lead pode editar usuários.";
            if (string.IsNullOrWhiteSpace(usuarioDTO.Nome))
                return "Necessário informar o nome do usuário!";

            if (string.IsNullOrWhiteSpace(usuarioDTO.Logon))
                return "Necessário informar o nome para login!";

            if (usuarioDTO.TipoUsuarioId == 0)
                return "Necessário informar o tipo de usuário!";
            if (usuarioDTO.Nome.Length > 30 || usuarioDTO.Logon.Length > 30)
                return "Nome e logon devem ter até 30 caracteres.";
            if (!string.IsNullOrWhiteSpace(usuarioDTO.Senha) && Encoding.UTF8.GetByteCount(usuarioDTO.Senha) > 72)
                return "A senha excede o limite de 72 bytes.";

            var usuario = new Usuario
            {
                Id = usuarioDTO.Id,
                Nome = usuarioDTO.Nome.Trim(),
                Logon = usuarioDTO.Logon.Trim(),
                Senha = string.IsNullOrWhiteSpace(usuarioDTO.Senha) ? string.Empty : BCrypt.Net.BCrypt.HashPassword(usuarioDTO.Senha, workFactor: 12),
                TipoUsuarioId = usuarioDTO.TipoUsuarioId
            };

            return _usuarioRepository.Edicao(usuario);
        }

        public string Exclusao(int idExclusao)
            => _usuarioRepository.ExclusaoPorId(idExclusao);

        public UsuarioDTO BuscarPorLogon(string logon)
        {
            var usuario = _usuarioRepository.BuscarPorLogon(logon);

            if (usuario is null)
                return null;

            var us = new UsuarioDTO
            {
                Id = usuario.Id,
                Logon = usuario.Logon,
                Senha = string.Empty,
                Nome = usuario.Nome,
                TipoUsuarioId = usuario.TipoUsuarioId
            };

            return us;
        }
    }
}
