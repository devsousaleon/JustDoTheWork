using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;

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
                Status = StatusAtividade.Analise,
                ProjetoId = dto.ProjetoId
            };
            mensagem = _repository.Inclusao(atividade);

            return mensagem;
        }
        public IEnumerable<AtualizaGridAtividadeDTO> PesquisarParaGrid(AtividadePesquisaDTO dto)
        {
            var filtro = new AtividadeFilter
            {
                Nome = dto.Nome,
                ProjetoId = dto.ProjetoId,
                Status = dto.Status,
                DataCriacao = dto.DataCriacao,
                DataFinalizacao = dto.DataFinalizacao
            };

            return _repository.PesquisarParaGrid(filtro);
        }

        public IEnumerable<LookUpDto> ObterStatusAtividade()
        {
            return Enum
                .GetValues(typeof(StatusAtividade))
                .Cast<StatusAtividade>()
                .Select(s => new LookUpDto
                {
                    Id = (int)s,
                    Status = s.ToString()
                });
        }

        public PesquisaFormAtividadeDTO ObtemDadosFormAtividade(int id)
        {
           var resposta = _repository.BuscarPorId(id);

            var dados = new PesquisaFormAtividadeDTO
            {
                Nome = resposta.Nome,
                Status = (int)resposta.Status,
                Descricao = resposta.Descricao,
                DataCriacao = resposta.DataCriacao,
                DataFinalizacao = resposta.DataFinalizacao,
                ProjetoId = resposta.ProjetoId
            };

            return dados;
        }

        public string EditaInformacaoAtividade(AtividadeDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Nome))
                return "Necessário informar o nome da atividade para salvar!";

            var atividade = new Atividade
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                Status = StatusAtividade.Analise,
                DataCriacao = dto.DataCriacao,
                DataFinalizacao = dto.DataFinalizacao,
                ProjetoId = dto.ProjetoId
            };

            return _repository.Edicao(atividade);

        }

        public string EditaInfoAvancaAtividade(AtividadeDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Nome))
                return "Necessário informar o nome da atividade para salvar!";

            if (string.IsNullOrWhiteSpace(dto.Descricao))
                return "Necessário informar os requisitos para esta atividade!";

            var atividade = new Atividade
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                Status = StatusAtividade.Pendente,
                DataCriacao = dto.DataCriacao,
                DataFinalizacao = dto.DataFinalizacao,
                ProjetoId = dto.ProjetoId
            };

            return _repository.Edicao(atividade);
        }

        public string Exclusao(int Id)
        {
            return _repository.ExclusaoPorId(Id);
        }
    }
}
