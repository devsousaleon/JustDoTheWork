using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IProjetoRepository
    {
        Result Inclusao(Projeto projeto);
        Result Edicao(Projeto projeto);
        Result ExclusaoPorId(int id);
        Projeto BuscarPorId(int id);
        IEnumerable<Projeto> Pesquisar(ProjetoFilter filtro);
    }
}