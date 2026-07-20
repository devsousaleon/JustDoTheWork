using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class AtividadeController
    {
        private readonly IAtividadeRepository _iAtividadeRepository;

        public AtividadeController(IAtividadeRepository repository)
        {
            _iAtividadeRepository = repository;
        }
        public string Cadastro(AtividadeDTO dtoAtividade)
        {
            var mensagem = "";

            if (dtoAtividade == null)
                return "Dados inválidos para inclusão!";

            if (string.IsNullOrWhiteSpace(dtoAtividade.Nome))
                return "É necessário informar o nome da atividade!";

            if (dtoAtividade.ProjetoId == 0)
                return "É necessário vincular a atividade a um projeto!";

            var atividade = new Atividade
            {
                Nome = dtoAtividade.Nome,
                Descricao = dtoAtividade.Descricao,
                Status = StatusAtividade.Analise,
                ProjetoId = dtoAtividade.ProjetoId
            };
            mensagem = _iAtividadeRepository.Inclusao(atividade);

            return mensagem;
        }
        public IEnumerable<AtualizaGridAtividadeDTO> PesquisarParaGrid(AtividadePesquisaDTO dtoAtividadePesquisa)
        {
            var filtro = new AtividadeFilter
            {
                Nome = dtoAtividadePesquisa.Nome,
                ProjetoId = dtoAtividadePesquisa.ProjetoId,
                Status = dtoAtividadePesquisa.Status,
                DataCriacao = dtoAtividadePesquisa.DataCriacao,
                DataFinalizacao = dtoAtividadePesquisa.DataFinalizacao
            };

            return _iAtividadeRepository.PesquisarParaGrid(filtro);
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

        public PesquisaFormAtividadeDTO ObtemDadosFormAtividade(int idObterDadosForm)
        {
           var resposta = _iAtividadeRepository.BuscarPorId(idObterDadosForm);

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

        public string EditaInformacaoAtividade(AtividadeDTO dtoAtividade, int StatusAtual)
        {
            if (string.IsNullOrWhiteSpace(dtoAtividade.Nome))
                return "Necessário informar o nome da atividade para salvar!";

            if (dtoAtividade.Descricao == null && dtoAtividade.Status != StatusAtividade.Analise)
                return "Necessário informar a descrição da atividade!";

            var atividade = new Atividade
            {
                Id = dtoAtividade.Id,
                Nome = dtoAtividade.Nome,
                Descricao = dtoAtividade.Descricao,
                Status = (StatusAtividade)StatusAtual,
                DataCriacao = dtoAtividade.DataCriacao,
                DataFinalizacao = dtoAtividade.DataFinalizacao,
                ProjetoId = dtoAtividade.ProjetoId
            };

            return _iAtividadeRepository.Edicao(atividade);

        }
        public string EditaInfoAvancaAtividade(AtividadeDTO dtoAtividade)
        {
            if (string.IsNullOrWhiteSpace(dtoAtividade.Nome))
                return "Necessário informar o nome da atividade para salvar!";

            if (dtoAtividade.Descricao == null)
                return "Necessário informar os requisitos para esta atividade!";

            var atividade = new Atividade
            {
                Id = dtoAtividade.Id,
                Nome = dtoAtividade.Nome,
                Descricao = dtoAtividade.Descricao,
                Status = StatusAtividade.Pendente,
                DataCriacao = dtoAtividade.DataCriacao,
                DataFinalizacao = dtoAtividade.DataFinalizacao,
                ProjetoId = dtoAtividade.ProjetoId
            };

            return _iAtividadeRepository.Edicao(atividade);
        }

        public string Exclusao(int idExclusao)
        {
            return _iAtividadeRepository.ExclusaoPorId(idExclusao);
        }

        public IEnumerable<AtualizaAtividadesExecucaoDTO> AtualizaGridAtividades(int Status)
        {
            return _iAtividadeRepository.BuscaParaGridAtividades(Status);
        }

        public string AlterarStatus(int idAlteraStatus, int statusAtual, int novoStatus)
        {
            if (!TransicaoPermitida(statusAtual, novoStatus))
                return "Essa ação não é permitida para esse status.";

            return _iAtividadeRepository.ExecutaAtividade(idAlteraStatus, novoStatus);
        }
        private bool TransicaoPermitida(int transicaoAtual, int transicaoNova)
        {
            switch (transicaoAtual)
            {
                case 2: // Pendente
                    return transicaoNova == 3;

                case 3: // Executando
                    return transicaoNova == 4 || transicaoNova == 2 || transicaoNova == 6;

                case 4: // Pausado
                    return transicaoNova == 3 || transicaoNova == 2;

                default:
                    return false;
            }
        }
    }
}