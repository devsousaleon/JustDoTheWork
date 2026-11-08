using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IExecucaoRepository
    {
        IEnumerable<ExecucaoDTO> BuscarPorAtividadeId(int atividadeId);
        VisualizaExecucaoAtividadeDTO BuscarDadosAtividade(int atividadeId);
    }
}
