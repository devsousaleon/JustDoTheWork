using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using System.Collections.Generic;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IProjetoRepository
    {
        string Inclusao(Projeto projeto);
        string Edicao(Projeto projeto);
        string ExclusaoPorId(int id);
        Projeto BuscarPorId(int id);
        IEnumerable<Projeto> Pesquisar(ProjetoFilter filtro);
    }
}
