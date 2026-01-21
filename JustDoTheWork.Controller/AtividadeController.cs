using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using JustDoTheWork.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustDoTheWork.Controller
{
    public class AtividadeController
    {
        private readonly IAtividadeRepository _repository;

        public AtividadeController(IAtividadeRepository repository)
        {
            _repository = repository;
        }


        public string Cadastro(AtividadeDTO dto)
        {
            var mensagem = "";

            if (dto == null)
                return "Dados inválidos para inclusão!";

            if (string.IsNullOrWhiteSpace(dto.Nome))
                return "É necessário informar o nome da atividade!";

            if (dto.ProjetoId == 0)
                return "É necessário vincular a atividade a um projeto!";

            var atividade = new Atividade
            {
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                Status = Entity.Domains.StatusAtividade.Analise,
                ProjetoId = dto.ProjetoId
            };
            mensagem = _repository.Inclusao(atividade);

            return mensagem;
        }
    }
}
