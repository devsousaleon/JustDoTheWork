using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IUsuarioRepository
    {
        string Inclusao(Usuario usuario);
        string Edicao(Usuario usuario);
        string ExclusaoPorId(int id);
        Usuario BuscarPorLogon(string logon);
        IEnumerable<TipoUsuario> BuscarTiposUsuario();
        Usuario? BuscarPorId(int id);
        IEnumerable<ResultadoPesquisaUsuarioDTO> Pesquisar(FiltroPesquisaUsuarioDTO filtro);
    }
}
