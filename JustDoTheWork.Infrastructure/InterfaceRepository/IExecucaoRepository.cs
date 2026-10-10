using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IExecucaoRepository
    {
        string Inclusao(Execucao execucao, JustDoTheWorkDbContext context);
        string FinalizarExecucao(Execucao execucao, JustDoTheWorkDbContext context);
        IEnumerable<ExecucaoDTO> BuscarPorAtividadeId(int atividadeId);
        VisualizaExecucaoAtividadeDTO BuscarDadosAtividade(int atividadeId);
    }
}
