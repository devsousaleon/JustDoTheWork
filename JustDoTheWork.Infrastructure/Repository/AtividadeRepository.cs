using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;

        public AtividadeRepository(JustDoTheWorkDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public string Inclusao(Atividade atividade)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {
                context.Atividades.Add(atividade);                
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception exception)
            {
                transacao.Rollback();
                return "Ocorreu um erro ao tentar realizar a ação de inclusão da atividade! " + exception.Message;
            }
        }

        public string Edicao(Atividade atividade)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {
                var atividadeExistente = context.Atividades.Find(atividade.Id)!;
                atividadeExistente.Nome = atividade.Nome;
                atividadeExistente.Descricao = atividade.Descricao;
                atividadeExistente.Status = atividade.Status;
                atividadeExistente.DataFinalizacao = atividade.DataFinalizacao;
                atividadeExistente.ProjetoId = atividade.ProjetoId;
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception exception)
            {
                transacao.Rollback();
                return "Ocorreu um erro ao tentar realizar a edição da atividade! " + exception.Message;
            }
        }
        public string ExclusaoPorId(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {                 
                var atividade = context.Atividades.Find(id)!;
                context.Atividades.Remove(atividade);
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception exception)
            {
                transacao.Rollback();
                return "Ocorreu um erro ao tentar excluir a atividade! " + exception.Message;
            }
        }
        public Atividade BuscarPorId(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            return context.Atividades.AsNoTracking().FirstOrDefault(atividade => atividade.Id == id)!;
        }
        public IEnumerable<AtualizaGridAtividadeDTO> PesquisarParaGrid(AtividadePesquisaDTO filtro)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var atividades = context.Atividades.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(filtro.Nome))
                atividades = atividades.Where(atividade => atividade.Nome.Contains(filtro.Nome));

            if (filtro.Status is > 0)
            {
                var status = (StatusAtividade)filtro.Status;
                atividades = atividades.Where(atividade => atividade.Status == status);
            }

            if (filtro.ProjetoId is > 0)
                atividades = atividades.Where(atividade => atividade.ProjetoId == filtro.ProjetoId);

            if (filtro.DataCriacao.HasValue)
            {
                var inicio = filtro.DataCriacao.Value;
                var fim = inicio.AddDays(1);
                atividades = atividades.Where(atividade => atividade.DataCriacao >= inicio && atividade.DataCriacao < fim);
            }

            return (
                from atividade in atividades
                join projeto in context.Projetos.AsNoTracking()
                    on atividade.ProjetoId equals projeto.Id
                select new AtualizaGridAtividadeDTO
                {
                    Id = atividade.Id,
                    Atividade = atividade.Nome,
                    Projeto = projeto.Nome
                }).ToList();
        }
        public IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarParaGridVisualizaHistorico(FiltroPesquisaHistoricoDTO filtro)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var atividades = context.Atividades.AsNoTracking().AsQueryable();

            if (filtro.Status is > 0)
            {
                var status = (StatusAtividade)filtro.Status.Value;
                atividades = atividades.Where(atividade => atividade.Status == status);
            }

            if (filtro.ProjetoId is > 0)
                atividades = atividades.Where(atividade => atividade.ProjetoId == filtro.ProjetoId.Value);

            if (filtro.DataCriacaoAtividade.HasValue)
            {
                var inicio = filtro.DataCriacaoAtividade.Value.Date;
                var fim = inicio.AddDays(1);
                atividades = atividades.Where(atividade => atividade.DataCriacao >= inicio && atividade.DataCriacao < fim);
            }

            return (
                from atividade in atividades
                join projeto in context.Projetos.AsNoTracking()
                    on atividade.ProjetoId equals projeto.Id
                join execucao in context.Execucoes.AsNoTracking()
                    on atividade.Id equals execucao.AtividadeId
                select new ResultadoPesquisaHistoricoDTO
                {
                    NomeAtividade = atividade.Nome,
                    NomeProjeto = projeto.Nome,
                    DataInicioExecucao = execucao.DataInicio,
                    DataFimExecucao = execucao.DataFim
                }).ToList();
        }
        public IEnumerable<AtualizaGridAtividadeDTO> BuscaParaGridAtividades(int status)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var statusAtividade = (StatusAtividade)status;

            return (
                from atividade in context.Atividades.AsNoTracking()
                join projeto in context.Projetos.AsNoTracking()
                    on atividade.ProjetoId equals projeto.Id
                where atividade.Status == statusAtividade
                select new AtualizaGridAtividadeDTO
                {
                    Id = atividade.Id,
                    Atividade = atividade.Nome,
                    Projeto = projeto.Nome
                }).ToList();
        }
        public string ExecutaAtividade(int id, int status, JustDoTheWorkDbContext context)
        {
            try
            {                
                var atividadeExistente = context.Atividades.Find(id)!;
                atividadeExistente.Status = (StatusAtividade)status;

                if (atividadeExistente.Status == StatusAtividade.Finalizado)
                    atividadeExistente.DataFinalizacao = DateTime.Now;

                context.SaveChanges();
                return "";
            }
            catch (Exception exception)
            {
                return "Ocorreu um erro ao tentar realizar a execução desta atividade! " + exception.Message;
            }
        }
    }
}
