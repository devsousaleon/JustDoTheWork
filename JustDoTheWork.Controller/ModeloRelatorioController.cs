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
            if (modeloRelatorioDTO.Descricao.Length > 50 || modeloRelatorioDTO.Texto is { Length: > 10 * 1024 * 1024 })
                return "Informe um nome com até 50 caracteres e um documento com até 10 MiB.";

            var modeloRelatorio = new ModeloRelatorio
            {
                Descricao = modeloRelatorioDTO.Descricao.Trim(),
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
            if (modeloRelatorioDTO.Descricao.Length > 50 || modeloRelatorioDTO.Texto is { Length: > 10 * 1024 * 1024 })
                return "Informe um nome com até 50 caracteres e um documento com até 10 MiB.";

            var modeloRelatorio = new ModeloRelatorioDTO
            {
                Id = modeloRelatorioDTO.Id,
                Descricao = modeloRelatorioDTO.Descricao.Trim(),
                TipoModeloId = modeloRelatorioDTO.TipoModeloId,
                Texto = modeloRelatorioDTO.Texto,
                Ativo = modeloRelatorioDTO.Ativo,
                Revisao = modeloRelatorioDTO.Revisao
            };

            return _modeloRelatorioRepository.Edicao(modeloRelatorio);
        }

        public string Exclusao(int id, string revisao)
            => _modeloRelatorioRepository.ExclusaoPorId(id, revisao);

        public byte[]? BuscarModeloHistoricoExecucao()
            => _modeloRelatorioRepository.BuscarModeloHistoricoExecucao();

        public IEnumerable<ResultadoPesquisaModeloRelatorioDTO> PesquisarModelosHistorico()
            => _modeloRelatorioRepository.PesquisarModelosHistorico();

        public DadosImpressaoHistoricoDTO BuscarDadosImpressaoHistorico(IEnumerable<int> execucaoIds, int? usuarioId, int? modeloId = null)
        {
            var ids = execucaoIds.Distinct().ToArray();
            if (ids.Length == 0 || ids.Length > 100 || ids.Any(id => id <= 0))
                throw new InvalidOperationException("Selecione entre 1 e 100 execuções para imprimir.");

            var dados = _modeloRelatorioRepository.BuscarDadosImpressaoHistorico(ids, usuarioId, modeloId);
            if (dados?.Modelo.Texto is not { Length: > 0 })
                throw new InvalidOperationException("Não foi encontrado modelo ativo com texto para impressão!");
            if (!DocumentoAtividade.TemConteudo(dados.Modelo.Texto))
                throw new InvalidOperationException("O modelo de impressão precisa de um documento válido com conteúdo.");

            if (dados.Registros.Count != ids.Length)
                throw new InvalidOperationException("Uma ou mais execuções não estão mais disponíveis. Atualize a pesquisa antes de imprimir.");

            var registrosPorId = dados.Registros.ToDictionary(registro => registro.Execucao.Id);
            dados.Registros = ids.Select(id => registrosPorId[id]).ToList();
            return dados;
        }
    }
}
