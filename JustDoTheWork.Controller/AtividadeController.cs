using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Infrastructure;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using JustDoTheWork.Infrastructure.Repository;

namespace JustDoTheWork.Controller
{
    public class AtividadeController
    {
        private readonly IAtividadeRepository _iAtividadeRepository;
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;

        public AtividadeController(IAtividadeRepository repository, JustDoTheWorkDbContextFactory dbContextFactory)
        {
            _iAtividadeRepository = repository;
            _dbContextFactory = dbContextFactory;
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
            => _iAtividadeRepository.ExclusaoPorId(idExclusao);

        public string Edicao(AtividadeDTO dtoAtividade, int StatusAtual)
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

        public string AvancarAtividade(AtividadeDTO dtoAtividade)
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

        public IEnumerable<AtualizaGridAtividadeDTO> PesquisarParaGrid(AtividadePesquisaDTO dtoAtividadePesquisa)
            => _iAtividadeRepository.PesquisarParaGrid(dtoAtividadePesquisa);

        public AtividadeDTO ObtemDadosFormAtividade(int idObterDadosForm)
        {
            var resposta = _iAtividadeRepository.BuscarPorId(idObterDadosForm);

            var dados = new AtividadeDTO
            {
                Nome = resposta.Nome,
                Status = resposta.Status,
                Descricao = resposta.Descricao,
                DataCriacao = resposta.DataCriacao,
                DataFinalizacao = resposta.DataFinalizacao,
                ProjetoId = resposta.ProjetoId
            };

            return dados;
        }

        public IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarParaGridVisualizaHistorico(FiltroPesquisaHistoricoDTO dtoFiltroPesquisaHistorico)
        {
            var filtro = new FiltroPesquisaHistoricoDTO
            {
                ProjetoId = dtoFiltroPesquisaHistorico.ProjetoId,
                Status = dtoFiltroPesquisaHistorico.Status,
                DataCriacaoAtividade = dtoFiltroPesquisaHistorico.DataCriacaoAtividade,
            };

            return _iAtividadeRepository.PesquisarParaGridVisualizaHistorico(filtro);
        }

        public IEnumerable<AtualizaGridAtividadeDTO> AtualizaGridAtividades(int Status)
            => _iAtividadeRepository.BuscaParaGridAtividades(Status);

        public string AlterarStatus(int idAtividade, int statusAtual, int novoStatus, string tipoExecucao)
        {
            if (!TransicaoPermitida(statusAtual, novoStatus))
                return "Essa ação não é permitida para esse status.";

            string mensagem = "";

            var execucaoRepository = new ExecucaoRepository();
            var execucao = new Execucao();

            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            
            mensagem = _iAtividadeRepository.ExecutaAtividade(idAtividade, novoStatus, context);

            if (mensagem != "")
            {
                transacao.Rollback();
                return mensagem;
            }

            if (tipoExecucao == "Edicao")
            {                
                execucao = new Execucao { AtividadeId = idAtividade, DataFim = DateTime.Now };

                mensagem = execucaoRepository.FinalizaExecucao(execucao, context);

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
