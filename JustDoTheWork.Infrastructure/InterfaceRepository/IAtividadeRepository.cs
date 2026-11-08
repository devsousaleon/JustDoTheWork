using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IAtividadeRepository
    {
        string Inclusao(Atividade atividade);
        string Edicao(AtividadeDTO atividade);
        string AlterarStatus(AtividadeDTO atividade, int novoStatus);
        string AvancarAtividade(AtividadeDTO atividade, int? usuarioDestinoId);
        string DevolverDesenvolvedor(AtividadeDTO atividade);
        string CancelarAtividade(AtividadeDTO atividade);
        string VincularResponsavel(AtividadeDTO atividade, int usuarioResponsavelId);
        string ExclusaoPorId(AtividadeDTO atividade);
        AtividadeDTO BuscarPorId(int id);
        IEnumerable<ResultadoPesquisaAtividadeDTO> Pesquisar(FiltroPesquisaAtividadeDTO filtro);
        IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarHistorico(FiltroPesquisaHistoricoDTO filtro);
        IEnumerable<ResultadoPesquisaAtividadeDTO> PesquisarPorStatus(params int[] status);
    }
}
