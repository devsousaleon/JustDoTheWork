using JustDoTheWork.DTO;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class ExecucaoController
    {
        private readonly IExecucaoRepository _execucaoRepository;

        public ExecucaoController(IExecucaoRepository repository)
        {
            _execucaoRepository = repository;
        }

        public IEnumerable<ExecucaoDTO> BuscarPorAtividadeId(int atividadeId)
            => _execucaoRepository.BuscarPorAtividadeId(atividadeId);

        public VisualizaExecucaoAtividadeDTO BuscarDadosAtividade(int atividadeId)
            => _execucaoRepository.BuscarDadosAtividade(atividadeId);
    }
}
