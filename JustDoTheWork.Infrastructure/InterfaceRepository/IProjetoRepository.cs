using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using System.Collections.Generic;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IProjetoRepository
    {
        void Inclusao(Projeto projeto);
        void Edicao(Projeto projeto);
        void ExclusaoPorId(int id);
        Projeto BuscarPorId(int id);
        IEnumerable<Projeto> Pesquisar(ProjetoFiltro filtro);
    }
}
