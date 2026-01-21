using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustDoTheWork.Controller
{
    public class ProjetoController
    {
        private readonly IProjetoRepository _repository;

        public ProjetoController(IProjetoRepository repository)
        {
            _repository = repository;
        }

        public string Inclusao(ProjetoDTO dto)
        {
            var mensagem = "";

            if (string.IsNullOrWhiteSpace(dto.Nome))
                return "O nome do projeto é obrigatório!";

            var projeto = new Projeto
            {
                Nome = dto.Nome
            };

            mensagem = _repository.Inclusao(projeto);

            return mensagem;
        }

        public IEnumerable<ProjetoComboDto> PesquisarParaCombo()
        {
            var projetos = _repository.Pesquisar(new ProjetoFilter());

            return projetos.Select(p => new ProjetoComboDto
            {
                Id = p.Id,
                Nome = p.Nome
            });
        }

    }
}
