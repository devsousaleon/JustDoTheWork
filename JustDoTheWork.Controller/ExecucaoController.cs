using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;

namespace JustDoTheWork.Controller
{
    public class ExecucaoController
    {
        private readonly IExecucaoRepository _repository;

        public ExecucaoController(IExecucaoRepository repository)
        {
            _repository = repository;
        }

        public string Inclusao(int Id)
        {
            var execucao = new Execucao
            {
                AtividadeId = Id
            };

            return _repository.Inclusao(execucao);
        }

        public string FinalizaExecucao(int Id)
        {
            var execucao = new Execucao { AtividadeId = Id, DataFim = DateTime.Now };
            return _repository.FinalizaExecucao(execucao);
        }

        public IEnumerable<ExecucaoDTO> InformaDadosExecucao(int AtividadeId)
        {
            return _repository.BuscarPorExecucoesPorAtividadeId(AtividadeId);
        }
        public VisualizaExecucaoAtividadeDTO InformaDadosAtividade(int AtividadeId)
        {
            return _repository.BuscaInfoAtividadeExecucao(AtividadeId);
        }


    }
}
