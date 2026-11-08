using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface IModeloRelatorioRepository
    {
        string Inclusao(ModeloRelatorio modeloRelatorio);
        string Edicao(ModeloRelatorioDTO modeloRelatorio);
        string ExclusaoPorId(int id, string revisao);
        ModeloRelatorioDTO BuscarPorId(int id);
        byte[]? BuscarModeloHistoricoExecucao();
        DadosImpressaoHistoricoDTO? BuscarDadosImpressaoHistorico(IReadOnlyCollection<int> execucaoIds, int? usuarioId, int? modeloId = null);
        IEnumerable<ResultadoPesquisaModeloRelatorioDTO> PesquisarModelosHistorico();
        IEnumerable<ResultadoPesquisaModeloRelatorioDTO> Pesquisar(FiltroPesquisaModeloRelatorioDTO filtroPesquisaModeloRelatorioDTO);
    }
}
