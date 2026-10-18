using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;
        private static readonly ConditionalWeakTable<JustDoTheWorkDbContextFactory, CacheConsulta<ProjetoDTO>> _cacheProjetos = new();

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
                _cacheProjetos.GetOrCreateValue(_dbContextFactory).Invalidar();
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
                _cacheProjetos.GetOrCreateValue(_dbContextFactory).Invalidar();
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
                _cacheProjetos.GetOrCreateValue(_dbContextFactory).Invalidar();
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
            var nome = filtro.Nome?.Trim();

            if (!string.IsNullOrEmpty(nome))
                projetos = projetos.Where(p => p.Nome.Contains(nome));

            return (
                from projeto in projetos
                select new ProjetoDTO
                {
                    Id = projeto.Id,
                    Nome = projeto.Nome
                }).ToList();
        }

        public IEnumerable<ProjetoDTO> PesquisarParaCombo()
        {
            return _cacheProjetos.GetOrCreateValue(_dbContextFactory).Obter(() =>
            {
                using var context = _dbContextFactory.CreateDbContext();
                return context.Projetos.AsNoTracking()
                    .Select(projeto => new ProjetoDTO
                    {
                        Id = projeto.Id,
                        Nome = projeto.Nome
                    }).ToList();
            }, projeto => new ProjetoDTO { Id = projeto.Id, Nome = projeto.Nome });
        }
    }
}
