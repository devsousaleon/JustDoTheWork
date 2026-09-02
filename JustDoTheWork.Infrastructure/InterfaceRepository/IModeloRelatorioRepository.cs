using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IModeloRelatorioRepository
    {
        Result Inclusao(ModeloRelatorio projeto);
        Result Edicao(ModeloRelatorio projeto);
        Result ExclusaoPorId(int id);
        ModeloRelatorioDTO BuscarPorId(int id);
        byte[]? BuscaModeloHistoricoExecucao();
        IEnumerable<ResultadoPesquisaModeloRelatorioDTO> Pesquisar(FiltroPesquisaModeloRelatorioDTO filtroPesquisaModeloRelatorioDTO);
    }
}