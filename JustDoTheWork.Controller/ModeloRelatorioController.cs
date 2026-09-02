using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class ModeloRelatorioController
    {
        private readonly IModeloRelatorioRepository _repository;

        public ModeloRelatorioController(IModeloRelatorioRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ResultadoPesquisaModeloRelatorioDTO> PesquisaModeloRelatorio(FiltroPesquisaModeloRelatorioDTO filtro)
            => _repository.Pesquisar(filtro);

        public Result Inclusao(ModeloRelatorioDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Descricao))
                return Result.Falha("Informe a descrição do modelo!");

            if (dto.TipoModeloId == 0)
                return Result.Falha("Informe o tipo do modelo!");

            var modelo = new ModeloRelatorio
            {
                Descricao = dto.Descricao,
                TipoModeloId = dto.TipoModeloId,
                Texto = dto.Texto,
                Ativo = dto.Ativo
            };

            return _repository.Inclusao(modelo);
        }

        public ModeloRelatorioDTO PreencheDadosTela(int id)
        {
            return _repository.BuscarPorId(id);
        }

        public Result Edicao(ModeloRelatorioDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Descricao))
                return Result.Falha("Informe a descrição do modelo!");

            if (dto.TipoModeloId == 0)
                return Result.Falha("Informe o tipo do modelo!");

            var modelo = new ModeloRelatorio
            {
                Id = dto.Id,
                Descricao = dto.Descricao,
                TipoModeloId = dto.TipoModeloId,
                Texto = dto.Texto,
                Ativo = dto.Ativo
            };

            return _repository.Edicao(modelo);
        }

        public Result Exclusao(int id)
        {
            return _repository.ExclusaoPorId(id);
        }

        public byte[]? BuscaModeloHistoricoExecucao()
        {
            return _repository.BuscaModeloHistoricoExecucao();
        }
    }
}
