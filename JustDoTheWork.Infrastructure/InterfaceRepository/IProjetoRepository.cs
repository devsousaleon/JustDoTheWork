using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IProjetoRepository
    {
        string Inclusao(Projeto projeto);
        string Edicao(Projeto projeto);
        string ExclusaoPorId(int id);
        Projeto BuscarPorId(int id);
        IEnumerable<ProjetoDTO> Pesquisar(ProjetoDTO filtro);
    }
}
