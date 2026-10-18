using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class ModeloRelatorioController
    {
        private readonly IModeloRelatorioRepository _modeloRelatorioRepository;

        public ModeloRelatorioController(IModeloRelatorioRepository repository)
        {
            _modeloRelatorioRepository = repository;
        }

        public IEnumerable<ResultadoPesquisaModeloRelatorioDTO> Pesquisar(FiltroPesquisaModeloRelatorioDTO filtroPesquisaModeloRelatorioDTO)
            => _modeloRelatorioRepository.Pesquisar(filtroPesquisaModeloRelatorioDTO);

        public string Inclusao(ModeloRelatorioDTO modeloRelatorioDTO)
        {
            if (string.IsNullOrWhiteSpace(modeloRelatorioDTO.Descricao))
                return "Informe a descrição do modelo!";

            if (modeloRelatorioDTO.TipoModeloId == 0)
                return "Informe o tipo do modelo!";

            var modeloRelatorio = new ModeloRelatorio
            {
                Descricao = modeloRelatorioDTO.Descricao,
                TipoModeloId = modeloRelatorioDTO.TipoModeloId,
                Texto = modeloRelatorioDTO.Texto,
                Ativo = modeloRelatorioDTO.Ativo
            };

            return _modeloRelatorioRepository.Inclusao(modeloRelatorio);
        }

        public ModeloRelatorioDTO BuscarPorId(int id)
            => _modeloRelatorioRepository.BuscarPorId(id);

        public string Edicao(ModeloRelatorioDTO modeloRelatorioDTO)
        {
            if (string.IsNullOrWhiteSpace(modeloRelatorioDTO.Descricao))
                return "Informe a descrição do modelo!";

            if (modeloRelatorioDTO.TipoModeloId == 0)
                return "Informe o tipo do modelo!";

            var modeloRelatorio = new ModeloRelatorio
            {
                Id = modeloRelatorioDTO.Id,
                Descricao = modeloRelatorioDTO.Descricao,
                TipoModeloId = modeloRelatorioDTO.TipoModeloId,
                Texto = modeloRelatorioDTO.Texto,
                Ativo = modeloRelatorioDTO.Ativo
            };

            return _modeloRelatorioRepository.Edicao(modeloRelatorio);
        }

        public string Exclusao(int id)
            => _modeloRelatorioRepository.ExclusaoPorId(id);

        public byte[]? BuscarModeloHistoricoExecucao()
            => _modeloRelatorioRepository.BuscarModeloHistoricoExecucao();

        public DadosImpressaoHistoricoDTO BuscarDadosImpressaoHistorico(IEnumerable<int> execucaoIds, int? usuarioId)
        {
            var ids = execucaoIds.Distinct().ToArray();
            if (ids.Length == 0 || ids.Any(id => id <= 0))
                throw new InvalidOperationException("Pesquise as execuções que deseja imprimir antes de gerar o relatório.");

            var dados = _modeloRelatorioRepository.BuscarDadosImpressaoHistorico(ids, usuarioId);
            if (dados?.Modelo.Texto is not { Length: > 0 })
                throw new InvalidOperationException("Não foi encontrado modelo ativo com texto para impressão!");

            if (dados.Registros.Count != ids.Length)
                throw new InvalidOperationException("Uma ou mais execuções não estão mais disponíveis. Atualize a pesquisa antes de imprimir.");

            var registrosPorId = dados.Registros.ToDictionary(registro => registro.Execucao.Id);
            dados.Registros = ids.Select(id => registrosPorId[id]).ToList();
            return dados;
        }
    }
}
