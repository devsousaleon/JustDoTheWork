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
        UsuarioLoginDTO? BuscarParaLogin(string logon);
        IEnumerable<UsuarioSelecaoDTO> PesquisarPorTipo(string tipoUsuario);
        IEnumerable<TipoUsuario> BuscarTiposUsuario();
        UsuarioDTO? BuscarPorId(int id);
        IEnumerable<ResultadoPesquisaUsuarioDTO> Pesquisar(FiltroPesquisaUsuarioDTO filtro);
    }
}
