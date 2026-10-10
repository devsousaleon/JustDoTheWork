using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IModeloRelatorioRepository
    {
        string Inclusao(ModeloRelatorio modeloRelatorio);
        string Edicao(ModeloRelatorio modeloRelatorio);
        string ExclusaoPorId(int id);
        ModeloRelatorioDTO BuscarPorId(int id);
        byte[]? BuscarModeloHistoricoExecucao();
        IEnumerable<ResultadoPesquisaModeloRelatorioDTO> Pesquisar(FiltroPesquisaModeloRelatorioDTO filtroPesquisaModeloRelatorioDTO);
    }
}
