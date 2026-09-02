using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class AtividadeController
    {
        private readonly IAtividadeRepository _repository;
        private readonly IExecucaoRepository _execucaoRepository;
        private readonly IUnitOfWorkFactory _uowFactory;

        public AtividadeController(
            IAtividadeRepository repository,
            IExecucaoRepository execucaoRepository,
            IUnitOfWorkFactory uowFactory)
        {
            _repository = repository;
            _execucaoRepository = execucaoRepository;
            _uowFactory = uowFactory;
        }

        public Result Cadastro(AtividadeDTO dtoAtividade)
        {
            if (dtoAtividade == null)
                return Result.Falha("Dados inválidos para inclusão!");

            if (string.IsNullOrWhiteSpace(dtoAtividade.Nome))
                return Result.Falha("É necessário informar o nome da atividade!");

            if (dtoAtividade.ProjetoId == 0)
                return Result.Falha("É necessário vincular a atividade a um projeto!");

            var atividade = new Atividade
            {
                Nome = dtoAtividade.Nome,
                Descricao = dtoAtividade.Descricao,
                Status = StatusAtividade.Analise,
                ProjetoId = dtoAtividade.ProjetoId
            };

            return _repository.Inclusao(atividade);
        }

        public Result AlterarStatus(int id, int statusAtual, int novoStatus)
        {
            var atual = (StatusAtividade)statusAtual;
            var novo = (StatusAtividade)novoStatus;

            if (!TransicaoStatusAtividade.Permitida(atual, novo))
                return Result.Falha("Essa ação não é permitida para esse status.");

            try
            {
                using var uow = _uowFactory.Create();
                uow.Begin();

                if (novo == StatusAtividade.Executando)
                {
                    var outraAtividadeExecutando = _repository.BuscarAtividadeEmExecucaoExceto(id, uow.Transaction);
                    if (outraAtividadeExecutando.HasValue)
                    {
                        _execucaoRepository.FinalizarAberta(outraAtividadeExecutando.Value, DateTime.Now, uow.Transaction);
                        _repository.AlterarStatus(outraAtividadeExecutando.Value, StatusAtividade.Pausado, null, uow.Transaction);
                    }

                    if (!_execucaoRepository.ExisteExecucaoAberta(id, uow.Transaction))
                        _execucaoRepository.Incluir(new Execucao { AtividadeId = id, DataInicio = DateTime.Now }, uow.Transaction);
                }
                else if (TransicaoStatusAtividade.RequerFecharExecucao(atual, novo))
                {
                    _execucaoRepository.FinalizarAberta(id, DateTime.Now, uow.Transaction);
                }

                DateTime? dataFinalizacao = novo == StatusAtividade.Finalizado ? DateTime.Now : null;
                _repository.AlterarStatus(id, novo, dataFinalizacao, uow.Transaction);

                uow.Commit();
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Falha("Não foi possível alterar o status da atividade.", ex);
            }
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

            return _repository.PesquisarParaGrid(filtro);
        }

        public IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarParaGridVisualizaHistorico(FiltroPesquisaHistoricoDTO dtoFiltroPesquisaHistorico)
        {
            return _repository.PesquisarParaGridVisualizaHistorico(dtoFiltroPesquisaHistorico);
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

            return new PesquisaFormAtividadeDTO
            {
                Nome = resposta.Nome,
                Status = (int)resposta.Status,
                Descricao = resposta.Descricao,
                DataCriacao = resposta.DataCriacao,
                DataFinalizacao = resposta.DataFinalizacao,
                ProjetoId = resposta.ProjetoId
            };
        }

        public Result EditaInformacaoAtividade(AtividadeDTO dtoAtividade, int statusAtual)
        {
            if (string.IsNullOrWhiteSpace(dtoAtividade.Nome))
                return Result.Falha("Necessário informar o nome da atividade para salvar!");

            if (dtoAtividade.Descricao == null && dtoAtividade.Status != StatusAtividade.Analise)
                return Result.Falha("Necessário informar a descrição da atividade!");

            var atividade = new Atividade
            {
                Id = dtoAtividade.Id,
                Nome = dtoAtividade.Nome,
                Descricao = dtoAtividade.Descricao,
                Status = (StatusAtividade)statusAtual,
                DataCriacao = dtoAtividade.DataCriacao,
                DataFinalizacao = dtoAtividade.DataFinalizacao,
                ProjetoId = dtoAtividade.ProjetoId
            };

            return _repository.Edicao(atividade);
        }

        public Result EditaInfoAvancaAtividade(AtividadeDTO dtoAtividade)
        {
            if (string.IsNullOrWhiteSpace(dtoAtividade.Nome))
                return Result.Falha("Necessário informar o nome da atividade para salvar!");

            if (dtoAtividade.Descricao == null)
                return Result.Falha("Necessário informar os requisitos para esta atividade!");

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

            return _repository.Edicao(atividade);
        }

        public Result Exclusao(int id)
        {
            return _repository.ExclusaoPorId(id);
        }

        public IEnumerable<AtualizaAtividadesExecucaoDTO> AtualizaGridAtividades(StatusAtividade status)
        {
            return _repository.BuscaParaGridAtividades(status);
        }
    }
}