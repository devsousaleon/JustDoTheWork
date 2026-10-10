using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using JustDoTheWork.Infrastructure.Repository;

namespace JustDoTheWork.Controller
{
    public class AtividadeController
    {
        private readonly IAtividadeRepository _atividadeRepository;
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;

        public AtividadeController(IAtividadeRepository repository, JustDoTheWorkDbContextFactory dbContextFactory)
        {
            _atividadeRepository = repository;
            _dbContextFactory = dbContextFactory;
        }

        public string Inclusao(AtividadeDTO atividadeDTO)
        {
            var mensagem = "";

            if (atividadeDTO == null)
                return "Dados inválidos para inclusão!";

            if (string.IsNullOrWhiteSpace(atividadeDTO.Nome))
                return "É necessário informar o nome da atividade!";

            if (atividadeDTO.ProjetoId == 0)
                return "É necessário vincular a atividade a um projeto!";

            var atividade = new Atividade
            {
                Nome = atividadeDTO.Nome,
                Descricao = atividadeDTO.Descricao,
                Status = StatusAtividade.Analise,
                ProjetoId = atividadeDTO.ProjetoId
            };
            mensagem = _atividadeRepository.Inclusao(atividade);

            return mensagem;
        }

        public IEnumerable<StatusDTO> ObterStatusAtividade()
        {
            return Enum
                .GetValues(typeof(StatusAtividade))
                .Cast<StatusAtividade>()
                .Select(s => new StatusDTO
                {
                    Id = (int)s,
                    Status = s.ToString()
                });
        }

        public string Exclusao(int idExclusao)
            => _atividadeRepository.ExclusaoPorId(idExclusao);

        public string Edicao(AtividadeDTO atividadeDTO, int statusAtual)
        {
            if (string.IsNullOrWhiteSpace(atividadeDTO.Nome))
                return "Necessário informar o nome da atividade para salvar!";

            if (atividadeDTO.Descricao == null && atividadeDTO.Status != StatusAtividade.Analise)
                return "Necessário informar a descrição da atividade!";

            var atividade = new Atividade
            {
                Id = atividadeDTO.Id,
                Nome = atividadeDTO.Nome,
                Descricao = atividadeDTO.Descricao,
                Status = (StatusAtividade)statusAtual,
                DataCriacao = atividadeDTO.DataCriacao,
                DataFinalizacao = atividadeDTO.DataFinalizacao,
                ProjetoId = atividadeDTO.ProjetoId
            };

            return _atividadeRepository.Edicao(atividade);

        }

        public string AvancarAtividade(AtividadeDTO atividadeDTO)
        {
            if (string.IsNullOrWhiteSpace(atividadeDTO.Nome))
                return "Necessário informar o nome da atividade para salvar!";

            if (atividadeDTO.Descricao == null)
                return "Necessário informar os requisitos para esta atividade!";

            var atividade = new Atividade
            {
                Id = atividadeDTO.Id,
                Nome = atividadeDTO.Nome,
                Descricao = atividadeDTO.Descricao,
                Status = StatusAtividade.Pendente,
                DataCriacao = atividadeDTO.DataCriacao,
                DataFinalizacao = atividadeDTO.DataFinalizacao,
                ProjetoId = atividadeDTO.ProjetoId
            };

            return _atividadeRepository.Edicao(atividade);
        }

        public string CancelarAtividade(AtividadeDTO atividadeDTO)
        {
            if (string.IsNullOrWhiteSpace(atividadeDTO.Nome))
                return "Necessário informar o nome da atividade para salvar!";

            if (atividadeDTO.Descricao == null)
                return "Necessário informar os requisitos para esta atividade!";

            var atividade = new Atividade
            {
                Id = atividadeDTO.Id,
                Nome = atividadeDTO.Nome,
                Descricao = atividadeDTO.Descricao,
                Status = StatusAtividade.Cancelado,
                DataCriacao = atividadeDTO.DataCriacao,
                DataFinalizacao = DateTime.Now,
                ProjetoId = atividadeDTO.ProjetoId
            };

            return _atividadeRepository.Edicao(atividade);
        }

        public IEnumerable<ResultadoPesquisaAtividadeDTO> Pesquisar(FiltroPesquisaAtividadeDTO filtroPesquisaAtividadeDTO)
            => _atividadeRepository.Pesquisar(filtroPesquisaAtividadeDTO);

        public AtividadeDTO BuscarPorId(int id)
        {
            var atividade = _atividadeRepository.BuscarPorId(id);

            var atividadeDTO = new AtividadeDTO
            {
                Nome = atividade.Nome,
                Status = atividade.Status,
                Descricao = atividade.Descricao,
                DataCriacao = atividade.DataCriacao,
                DataFinalizacao = atividade.DataFinalizacao,
                ProjetoId = atividade.ProjetoId
            };

            return atividadeDTO;
        }

        public IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarHistorico(FiltroPesquisaHistoricoDTO filtroPesquisaHistoricoDTO)
        {
            var filtro = new FiltroPesquisaHistoricoDTO
            {
                ProjetoId = filtroPesquisaHistoricoDTO.ProjetoId,
                Status = filtroPesquisaHistoricoDTO.Status,
                DataCriacaoAtividade = filtroPesquisaHistoricoDTO.DataCriacaoAtividade,
            };

            return _atividadeRepository.PesquisarHistorico(filtro);
        }

        public IEnumerable<ResultadoPesquisaAtividadeDTO> PesquisarPorStatus(int status)
            => _atividadeRepository.PesquisarPorStatus(status);

        public string AlterarStatus(int idAtividade, int statusAtual, int novoStatus, string tipoExecucao)
        {
            if (!TransicaoPermitida(statusAtual, novoStatus))
                return "Essa ação não é permitida para esse status.";

            string mensagem = "";

            var execucaoRepository = new ExecucaoRepository();
            var execucao = new Execucao();

            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            
            mensagem = _atividadeRepository.AlterarStatus(idAtividade, novoStatus, context);

            if (mensagem != "")
            {
                transacao.Rollback();
                return mensagem;
            }

            if (tipoExecucao == "Edicao")
            {                
                execucao = new Execucao { AtividadeId = idAtividade, DataFim = DateTime.Now };

                mensagem = execucaoRepository.FinalizarExecucao(execucao, context);

                if (mensagem != "")
                {
                    transacao.Rollback();
                    return mensagem;
                }
            }

            if (tipoExecucao == "Inclusao")
            {
                execucao = new Execucao { AtividadeId = idAtividade, DataInicio = DateTime.Now };

                mensagem = execucaoRepository.Inclusao(execucao, context);

                if (mensagem != "")
                {
                    transacao.Rollback();
                    return mensagem;
                }
            }

            transacao.Commit();
            return mensagem;
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
