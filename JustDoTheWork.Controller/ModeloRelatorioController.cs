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
    }
}
