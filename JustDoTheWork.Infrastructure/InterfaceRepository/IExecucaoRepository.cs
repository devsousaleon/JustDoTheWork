using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using System.Data;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IExecucaoRepository
    {
        Result Inclusao(Execucao execucao);
        Result FinalizaExecucao(Execucao execucao);
        IEnumerable<ExecucaoDTO> BuscarPorExecucoesPorAtividadeId(int atividadeId);
        VisualizaExecucaoAtividadeDTO BuscaInfoAtividadeExecucao(int atividadeId);
        bool ExisteExecucaoAberta(int atividadeId, IDbTransaction transacao);
        void Incluir(Execucao execucao, IDbTransaction transacao);
        void FinalizarAberta(int atividadeId, DateTime dataFim, IDbTransaction transacao);
    }
}
