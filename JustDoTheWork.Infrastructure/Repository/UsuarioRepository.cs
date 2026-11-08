using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Entity;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;
        private readonly UsuarioSessaoDTO? _usuario;
        private static readonly ConditionalWeakTable<JustDoTheWorkDbContextFactory, CacheConsulta<TipoUsuario>> _cacheTiposUsuario = new();

        public UsuarioRepository(JustDoTheWorkDbContextFactory dbContextFactory, UsuarioSessaoDTO? usuario = null)
        {
            _dbContextFactory = dbContextFactory;
            _usuario = usuario;
        }

        public string Inclusao(Usuario usuario)
        {
            if (_usuario?.EhTechLead != true)
                return "Somente o Tech Lead pode cadastrar usuários.";
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                var mensagem = ValidarCadastro(context, usuario);
                if (mensagem != "") return mensagem;
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
            if (_usuario?.EhTechLead != true)
                return "Somente o Tech Lead pode editar usuários.";
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
            try
            {
                var existente = context.Usuarios.SingleOrDefault(cadastro => cadastro.Id == usuario.Id);
                if (existente == null) return "Usuário não encontrado.";
                var mensagem = ValidarCadastro(context, usuario);
                if (mensagem != "") return mensagem;
                existente.Nome = usuario.Nome;
                existente.Logon = usuario.Logon;
                existente.TipoUsuarioId = usuario.TipoUsuarioId;
                if (!string.IsNullOrWhiteSpace(usuario.Senha)) existente.Senha = usuario.Senha;
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
            if (_usuario?.EhTechLead != true)
                return "Somente o Tech Lead pode excluir usuários.";
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
            try
            {
                var usuario = context.Usuarios.Find(id);
                if (usuario == null) return "Usuário não encontrado.";
                if (context.Atividades.Any(atividade => atividade.UsuarioResponsavelId == id || atividade.UltimoDesenvolvedorId == id) ||
                    context.Execucoes.Any(execucao => execucao.UsuarioId == id))
                    return "O usuário possui atividades ou execuções vinculadas e não pode ser excluído.";
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
            if (_usuario?.EhTechLead != true) return null!;
            using var context = _dbContextFactory.CreateDbContext();
            return context.Usuarios.AsNoTracking().FirstOrDefault(u => u.Logon == logon);
        }

        public UsuarioLoginDTO? BuscarParaLogin(string logon)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var candidatos = (from usuario in context.Usuarios.AsNoTracking()
                join tipo in context.TiposUsuario.AsNoTracking() on usuario.TipoUsuarioId equals tipo.Id
                where usuario.Logon == logon.Trim()
                select new UsuarioLoginDTO
                {
                    Id = usuario.Id,
                    Nome = usuario.Nome,
                    TipoUsuarioId = usuario.TipoUsuarioId,
                    TipoUsuario = tipo.Tipo,
                    Senha = usuario.Senha
                }).Take(2).ToList();
            return candidatos.Count == 1 ? candidatos[0] : null;
        }

        public IEnumerable<UsuarioSelecaoDTO> PesquisarPorTipo(string tipoUsuario)
        {
            if (_usuario == null)
                return Array.Empty<UsuarioSelecaoDTO>();
            using var context = _dbContextFactory.CreateDbContext();
            var tipo = tipoUsuario.ToUpperInvariant();
            return (from usuario in context.Usuarios.AsNoTracking()
                join tipoCadastro in context.TiposUsuario.AsNoTracking() on usuario.TipoUsuarioId equals tipoCadastro.Id
                where tipoCadastro.Tipo.ToUpper() == tipo
                orderby usuario.Nome, usuario.Id
                select new UsuarioSelecaoDTO { Id = usuario.Id, Nome = usuario.Nome }).ToList();
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
            if (_usuario?.EhTechLead != true)
                return null;
            using var context = _dbContextFactory.CreateDbContext();
            return context.Usuarios.AsNoTracking()
                .Where(usuario => usuario.Id == id)
                .Select(usuario => new UsuarioDTO
                {
                    Id = usuario.Id,
                    Nome = usuario.Nome,
                    Logon = usuario.Logon,
                    Senha = string.Empty,
                    TipoUsuarioId = usuario.TipoUsuarioId
                }).FirstOrDefault();
        }

        public IEnumerable<ResultadoPesquisaUsuarioDTO> Pesquisar(FiltroPesquisaUsuarioDTO filtro)
        {
            if (_usuario?.EhTechLead != true)
                return Array.Empty<ResultadoPesquisaUsuarioDTO>();
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

        private static string ValidarCadastro(JustDoTheWorkDbContext context, Usuario usuario)
        {
            var tipo = context.TiposUsuario.Where(cadastro => cadastro.Id == usuario.TipoUsuarioId).Select(cadastro => cadastro.Tipo).FirstOrDefault();
            if (tipo == null || !FluxoAtividade.TipoUsuarioValido(tipo))
                return "Selecione um tipo de usuário existente e válido.";
            if (context.Usuarios.Any(cadastro => cadastro.Id != usuario.Id && cadastro.Logon == usuario.Logon))
                return "Este logon já está cadastrado.";
            return "";
        }
    }
}
