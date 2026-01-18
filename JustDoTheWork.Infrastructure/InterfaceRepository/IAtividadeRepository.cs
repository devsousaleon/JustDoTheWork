using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using System.Collections.Generic;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IAtividadeRepository
    {
        void Inclusao(Atividade atividade);
        void Edicao(Atividade atividade);
        void ExclusaoPorId(int id);
        Atividade BuscarPorId(int id);
       IEnumerable<Atividade> Pesquisar(AtividadeFiltro filtro);
    }
}
