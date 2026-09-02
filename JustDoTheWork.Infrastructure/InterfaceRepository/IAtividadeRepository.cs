using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using System.Data;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IAtividadeRepository
    {
        Result Inclusao(Atividade atividade);
        Result Edicao(Atividade atividade);
        Result ExclusaoPorId(int id);
        Atividade BuscarPorId(int id);
        IEnumerable<AtualizaGridAtividadeDTO> PesquisarParaGrid(AtividadeFilter filtro);
        IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarParaGridVisualizaHistorico(FiltroPesquisaHistoricoDTO filtro);
        IEnumerable<AtualizaAtividadesExecucaoDTO> BuscaParaGridAtividades(StatusAtividade status);
        IEnumerable<DashboardProjetoTempoDTO> BuscarTempoPorProjetoNoDia(DateTime dia);
        DashboardDiaDTO BuscarResumoDia(DateTime dia);
        int? BuscarAtividadeEmExecucaoExceto(int atividadeId, IDbTransaction transacao);
        void AlterarStatus(int id, StatusAtividade status, DateTime? dataFinalizacao, IDbTransaction transacao);
    }
}
