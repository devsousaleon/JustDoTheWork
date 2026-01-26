using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using System.Collections.Generic;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IAtividadeRepository
    {
        string Inclusao(Atividade atividade);
        string Edicao(Atividade atividade);
        string ExecutaAtividade(int Id, int Status);
        string ExclusaoPorId(int id);
        Atividade BuscarPorId(int id);
        IEnumerable<AtualizaGridAtividadeDTO> PesquisarParaGrid(AtividadeFilter filtro);
        IEnumerable<AtualizaAtividadesExecucaoDTO> BuscaParaGridAtividades(int Status);
    }
}
