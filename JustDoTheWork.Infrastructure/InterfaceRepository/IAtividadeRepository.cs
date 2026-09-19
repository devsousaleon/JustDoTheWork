using JustDoTheWork.DTO;
using JustDoTheWork.Entity;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IAtividadeRepository
    {
        string Inclusao(Atividade atividade);
        string Edicao(Atividade atividade);
        string ExecutaAtividade(int Id, int Status, JustDoTheWorkDbContext context);
        string ExclusaoPorId(int id);
        Atividade BuscarPorId(int id);
        IEnumerable<AtualizaGridAtividadeDTO> PesquisarParaGrid(AtividadePesquisaDTO filtro);
        IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarParaGridVisualizaHistorico(FiltroPesquisaHistoricoDTO filtro);
        IEnumerable<AtualizaGridAtividadeDTO> BuscaParaGridAtividades(int Status);
    }
}