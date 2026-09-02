using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class ExecucaoController
    {
        private readonly IExecucaoRepository _repository;

        public ExecucaoController(IExecucaoRepository repository)
        {
            _repository = repository;
        }

        public Result Inclusao(int id)
        {
            var execucao = new Execucao
            {
                AtividadeId = id
            };

            return _repository.Inclusao(execucao);
        }

        public Result FinalizaExecucao(int id)
        {
            var execucao = new Execucao
            {
                AtividadeId = id,
                DataFim = DateTime.Now
            };

            return _repository.FinalizaExecucao(execucao);
        }

        public IEnumerable<ExecucaoDTO> InformaDadosExecucao(int atividadeId)
        {
            return _repository.BuscarPorExecucoesPorAtividadeId(atividadeId);
        }

        public VisualizaExecucaoAtividadeDTO InformaDadosAtividade(int atividadeId)
        {
            return _repository.BuscaInfoAtividadeExecucao(atividadeId);
        }
    }
}
