using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IModeloRelatorioRepository
    {
        string Inclusao(ModeloRelatorio projeto);
        string Edicao(ModeloRelatorio projeto);
        string ExclusaoPorId(int id);
        ModeloRelatorioDTO BuscarPorId(int id);
        byte[]? BuscaModeloHistoricoExecucao();
        IEnumerable<ResultadoPesquisaModeloRelatorioDTO> Pesquisar(FiltroPesquisaModeloRelatorioDTO filtroPesquisaModeloRelatorioDTO);
    }
}