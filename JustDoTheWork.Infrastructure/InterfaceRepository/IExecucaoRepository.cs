using JustDoTheWork.Entity;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IExecucaoRepository
    {
        void Inclusao(Execucao execucao);
        Execucao BuscarPorAtividadeId(int id);
    }
}
