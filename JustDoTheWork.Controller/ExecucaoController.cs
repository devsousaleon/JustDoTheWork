using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
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
        public string Inclusao(int Id)
        {
            var execucao = new Execucao
            {
                AtividadeId = Id
            };

            return _iExecucaoRepository.Inclusao(execucao);
        }
        public string FinalizaExecucao(int Id)
        {
            var execucao = new Execucao { AtividadeId = Id, DataFim = DateTime.Now };
            return _iExecucaoRepository.FinalizaExecucao(execucao);
        }
        public IEnumerable<ExecucaoDTO> InformaDadosExecucao(int AtividadeId)
        {
            return _iExecucaoRepository.BuscarPorExecucoesPorAtividadeId(AtividadeId);
        }
        public VisualizaExecucaoAtividadeDTO InformaDadosAtividade(int AtividadeId)
        {
            return _iExecucaoRepository.BuscaInfoAtividadeExecucao(AtividadeId);
        }
    }
}