using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using System.Collections.Generic;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IAtividadeRepository
    {
        string Inclusao(Atividade atividade);
        string Edicao(Atividade atividade);
        string ExclusaoPorId(int id);
        Atividade BuscarPorId(int id);
       IEnumerable<Atividade> Pesquisar(AtividadeFilter filtro);
    }
}
