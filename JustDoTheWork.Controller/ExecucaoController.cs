using JustDoTheWork.DTO;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class ExecucaoController
    {
        private readonly IExecucaoRepository _iExecucaoRepository;

        public ExecucaoController(IExecucaoRepository repository)
        {
            _iExecucaoRepository = repository;
        }

        public IEnumerable<ExecucaoDTO> InformaDadosExecucao(int AtividadeId)
            => _iExecucaoRepository.BuscarPorExecucoesPorAtividadeId(AtividadeId);

        public VisualizaExecucaoAtividadeDTO InformaDadosAtividade(int AtividadeId)
            => _iExecucaoRepository.BuscaInfoAtividadeExecucao(AtividadeId);
    }
}
