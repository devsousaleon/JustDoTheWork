using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IAtividadeRepository
    {
        string Inclusao(Atividade atividade);
        string Edicao(Atividade atividade);
        string AlterarStatus(int id, int status, JustDoTheWorkDbContext context);
        string ExclusaoPorId(int id);
        AtividadeDTO BuscarPorId(int id);
        IEnumerable<ResultadoPesquisaAtividadeDTO> Pesquisar(FiltroPesquisaAtividadeDTO filtro);
        IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarHistorico(FiltroPesquisaHistoricoDTO filtro);
        IEnumerable<ResultadoPesquisaAtividadeDTO> PesquisarPorStatus(params int[] status);
    }
}
