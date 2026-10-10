using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;

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
            return context.Usuarios.FirstOrDefault(u => u.Logon == logon);
        }
    }
}
