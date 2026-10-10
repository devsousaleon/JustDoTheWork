using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class ProjetoController
    {
        private readonly IProjetoRepository _projetoRepository;

        public ProjetoController(IProjetoRepository repository)
        {
            _projetoRepository = repository;
        }

        public string Inclusao(ProjetoDTO projetoDTO)
        {
            var mensagem = "";

            if (string.IsNullOrWhiteSpace(projetoDTO.Nome))
                return "O nome do projeto é obrigatório!";

            var projeto = new Projeto
            {
                Nome = projetoDTO.Nome
            };

            mensagem = _projetoRepository.Inclusao(projeto);

            return mensagem;
        }

        public IEnumerable<ProjetoDTO> PesquisarParaCombo()
            => _projetoRepository.Pesquisar(new ProjetoDTO());
    }
}
