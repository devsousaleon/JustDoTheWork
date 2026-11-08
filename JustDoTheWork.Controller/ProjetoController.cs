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
            if (projetoDTO.Nome.Length > 50)
                return "O nome do projeto deve ter até 50 caracteres.";

            var projeto = new Projeto
            {
                Nome = projetoDTO.Nome.Trim()
            };

            mensagem = _projetoRepository.Inclusao(projeto);

            return mensagem;
        }

        public IEnumerable<ProjetoDTO> PesquisarParaCombo()
            => _projetoRepository.PesquisarParaCombo();
    }
}
