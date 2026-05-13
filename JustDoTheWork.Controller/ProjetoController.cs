using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class ProjetoController
    {
        private readonly IProjetoRepository _iProjetoRepository;

        public ProjetoController(IProjetoRepository repository)
        {
            _iProjetoRepository = repository;
        }

        public string Inclusao(ProjetoDTO dtoProjeto)
        {
            var mensagem = "";

            if (string.IsNullOrWhiteSpace(dtoProjeto.Nome))
                return "O nome do projeto é obrigatório!";

            var projeto = new Projeto
            {
                Nome = dtoProjeto.Nome
            };

            mensagem = _iProjetoRepository.Inclusao(projeto);

            return mensagem;
        }

        public IEnumerable<ProjetoComboDto> PesquisarParaCombo()
        {
            var projetos = _iProjetoRepository.Pesquisar(new ProjetoFilter());

            return projetos.Select(p => new ProjetoComboDto
            {
                Id = p.Id,
                Nome = p.Nome
            });
        }
    }
}