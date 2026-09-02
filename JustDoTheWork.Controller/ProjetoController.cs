using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class ProjetoController
    {
        private readonly IProjetoRepository _repository;

        public ProjetoController(IProjetoRepository repository)
        {
            _repository = repository;
        }

        public Result Inclusao(ProjetoDTO dtoProjeto)
        {
            if (string.IsNullOrWhiteSpace(dtoProjeto.Nome))
                return Result.Falha("O nome do projeto é obrigatório!");

            var projeto = new Projeto
            {
                Nome = dtoProjeto.Nome
            };

            return _repository.Inclusao(projeto);
        }

        public IEnumerable<ProjetoComboDto> PesquisarParaCombo()
        {
            return _repository.Pesquisar(new ProjetoFilter())
                .Select(p => new ProjetoComboDto
                {
                    Id = p.Id,
                    Nome = p.Nome
                });
        }
    }
}
