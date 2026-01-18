using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using System.Collections.Generic;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IExecucaoRepository
    {
        void Inclusao(Execucao execucao);
        void Edicao(Execucao execucao);
        void ExclusaoPorId(int id);
        Execucao BuscarPorId(int id);
        IEnumerable<Execucao> Pesquisar(ExecucaoFiltro filtro);
    }
}
