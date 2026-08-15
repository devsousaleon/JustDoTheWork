using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class ModeloRelatorioController
    {
        private readonly IModeloRelatorioRepository _iModeloRepository;

        public ModeloRelatorioController(IModeloRelatorioRepository repository)
        {
            _iModeloRepository = repository;
        }

        public IEnumerable<ResultadoPesquisaModeloRelatorioDTO> PesquisaModeloRelatorio(FiltroPesquisaModeloRelatorioDTO filtroPesquisaModeloRelatorioDTO)
            => _iModeloRepository.Pesquisar(filtroPesquisaModeloRelatorioDTO);

        public string Inclusao(ModeloRelatorioDTO modeloRelatorioDTO)
        {
            if (string.IsNullOrWhiteSpace(modeloRelatorioDTO.Descricao))
                return "Informe a descrição do modelo!";

            if (modeloRelatorioDTO.TipoModeloId == 0)
                return "Informe o tipo do modelo!";

            var dados = new ModeloRelatorio
            {
                Descricao = modeloRelatorioDTO.Descricao,
                TipoModeloId = modeloRelatorioDTO.TipoModeloId,
                Texto = modeloRelatorioDTO.Texto,
                Ativo = modeloRelatorioDTO.Ativo
            };

            return _iModeloRepository.Inclusao(dados);
        }

        public ModeloRelatorioDTO PreencheDadosTela(int id)
        {
            return _iModeloRepository.BuscarPorId(id);
        }

        public string Edicao(ModeloRelatorioDTO modeloRelatorioDTO)
        {
            if (string.IsNullOrWhiteSpace(modeloRelatorioDTO.Descricao))
                return "Informe a descrição do modelo!";

            if (modeloRelatorioDTO.TipoModeloId == 0)
                return "Informe o tipo do modelo!";

            var dados = new ModeloRelatorio
            {
                Id = modeloRelatorioDTO.Id,
                Descricao = modeloRelatorioDTO.Descricao,
                TipoModeloId = modeloRelatorioDTO.TipoModeloId,
                Texto = modeloRelatorioDTO.Texto,
                Ativo = modeloRelatorioDTO.Ativo
            };

            return _iModeloRepository.Edicao(dados);
        }

        public string Exclusao(int Id)
        {
            return _iModeloRepository.ExclusaoPorId(Id);
        }

        public byte[]? BuscaModeloHistoricoExecucao()
        {
            return _iModeloRepository.BuscaModeloHistoricoExecucao();
        }
    }
}