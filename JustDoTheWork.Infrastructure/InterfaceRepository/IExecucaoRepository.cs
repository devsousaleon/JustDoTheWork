using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using System.Collections.Generic;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IExecucaoRepository
    {
        string Inclusao(Execucao execucao);
        string FinalizaExecucao(Execucao execucao);
        IEnumerable<ExecucaoDTO> BuscarPorExecucoesPorAtividadeId(int AtividadeId);
        VisualizaExecucaoAtividadeDTO BuscaInfoAtividadeExecucao(int AtividadeId);

    }
}
