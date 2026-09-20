using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;

        public ProjetoRepository(JustDoTheWorkDbContextFactory? dbContextFactory = null)
        {
            _dbContextFactory = dbContextFactory;
        }

        public string Inclusao(Projeto projeto)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();

            try
            {
                context.Add(projeto);
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return "Erro ao incluir projeto! " + ex.Message;
            }
        }

        public string Edicao(Projeto projeto)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return "Erro ao editar dados do projeto! " + ex.Message;
            }
        }

        public string ExclusaoPorId(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {
                var projeto = context.Projetos.Find(id)!;
                context.Projetos.Remove(projeto);
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return "Erro ao excluir projeto! " + ex.Message;
            }
        }

        public Projeto BuscarPorId(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            return context.Projetos.AsNoTracking().Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<ProjetoDTO> Pesquisar(ProjetoDTO filtro)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var projetos = context.Projetos.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(filtro.Nome))
                projetos = projetos.Where(p => p.Nome.Contains(filtro.Nome));

            return (
                from projeto in projetos
                select new ProjetoDTO
                {
                    Id = projeto.Id,
                    Nome = projeto.Nome
                }).ToList();
        }
    }
}
