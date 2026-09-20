using JustDoTheWork.DTO;
using JustDoTheWork.Entity;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IExecucaoRepository
    {
        string Inclusao(Execucao execucao, JustDoTheWorkDbContext context);
        string FinalizaExecucao(Execucao execucao, JustDoTheWorkDbContext context);
        IEnumerable<ExecucaoDTO> BuscarPorExecucoesPorAtividadeId(int AtividadeId);
        VisualizaExecucaoAtividadeDTO BuscaInfoAtividadeExecucao(int AtividadeId);
    }
}
