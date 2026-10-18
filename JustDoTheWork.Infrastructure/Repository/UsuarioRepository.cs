using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;
        private static readonly ConditionalWeakTable<JustDoTheWorkDbContextFactory, CacheConsulta<TipoUsuario>> _cacheTiposUsuario = new();

        public UsuarioRepository(JustDoTheWorkDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public string Inclusao(Usuario usuario)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();

            try
            {
                context.Add(usuario);
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return "Erro ao incluir usuário! " + ex.Message;
            }
        }        

        public string Edicao(Usuario usuario)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {
                context.Usuarios.Update(usuario);
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return "Erro ao editar dados do usuário! " + ex.Message;
            }
        }

        public string ExclusaoPorId(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {
                var usuario = context.Usuarios.Find(id)!;
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return "Erro ao excluir usuário! " + ex.Message;
            }
        }

        public Usuario BuscarPorLogon(string logon)
        {
            using var context = _dbContextFactory.CreateDbContext();
            return context.Usuarios.AsNoTracking().FirstOrDefault(u => u.Logon == logon);
        }

        public UsuarioLoginDTO? BuscarParaLogin(string logon)
        {
            using var context = _dbContextFactory.CreateDbContext();
            return context.Usuarios.AsNoTracking()
                .Where(usuario => usuario.Logon == logon)
                .Select(usuario => new UsuarioLoginDTO
                {
                    Id = usuario.Id,
                    Senha = usuario.Senha
                }).FirstOrDefault();
        }

        public IEnumerable<TipoUsuario> BuscarTiposUsuario()
        {
            return _cacheTiposUsuario.GetOrCreateValue(_dbContextFactory).Obter(() =>
            {
                using var context = _dbContextFactory.CreateDbContext();
                return context.TiposUsuario.AsNoTracking()
                    .Where(tipo => tipo.Tipo.ToUpper() == "HISTORIADOR" ||
                                   tipo.Tipo.ToUpper() == "DESENVOLVEDOR" ||
                                   tipo.Tipo.ToUpper() == "QA TESTER" ||
                                   tipo.Tipo.ToUpper() == "TECH LEAD")
                    .OrderBy(tipo => tipo.Tipo.ToUpper() == "HISTORIADOR" ? 0 :
                                     tipo.Tipo.ToUpper() == "DESENVOLVEDOR" ? 1 :
                                     tipo.Tipo.ToUpper() == "QA TESTER" ? 2 : 3)
                    .Select(tipo => new TipoUsuario
                    {
                        Id = tipo.Id,
                        Tipo = tipo.Tipo
                    }).ToList();
            }, tipo => new TipoUsuario { Id = tipo.Id, Tipo = tipo.Tipo });
        }

        public UsuarioDTO? BuscarPorId(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            return context.Usuarios.AsNoTracking()
                .Where(usuario => usuario.Id == id)
                .Select(usuario => new UsuarioDTO
                {
                    Id = usuario.Id,
                    Nome = usuario.Nome,
                    Logon = usuario.Logon,
                    Senha = usuario.Senha,
                    TipoUsuarioId = usuario.TipoUsuarioId
                }).FirstOrDefault();
        }

        public IEnumerable<ResultadoPesquisaUsuarioDTO> Pesquisar(FiltroPesquisaUsuarioDTO filtro)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var usuarios = context.Usuarios.AsNoTracking().AsQueryable();
            var nome = filtro.Nome?.Trim();
            var logon = filtro.Logon?.Trim();

            if (!string.IsNullOrEmpty(nome))
                usuarios = usuarios.Where(usuario => usuario.Nome.Contains(nome));

            if (!string.IsNullOrEmpty(logon))
                usuarios = usuarios.Where(usuario => usuario.Logon.Contains(logon));

            return (from usuario in usuarios
                    join tipoUsuario in context.TiposUsuario.AsNoTracking()
                        on usuario.TipoUsuarioId equals tipoUsuario.Id
                    orderby usuario.Nome, usuario.Logon
                    select new ResultadoPesquisaUsuarioDTO
                    {
                        Id = usuario.Id,
                        Nome = usuario.Nome,
                        Logon = usuario.Logon,
                        TipoUsuario = tipoUsuario.Tipo
                    }).ToList();
        }
    }
}
