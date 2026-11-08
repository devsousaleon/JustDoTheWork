using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ExecucaoRepository : IExecucaoRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;
        private readonly UsuarioSessaoDTO? _usuario;

        public ExecucaoRepository(JustDoTheWorkDbContextFactory? dbContextFactory = null, UsuarioSessaoDTO? usuario = null)
        {
            _dbContextFactory = dbContextFactory;
            _usuario = usuario;
        }

        public IEnumerable<ExecucaoDTO> BuscarPorAtividadeId(int atividadeId)
        {
            using var context = _dbContextFactory.CreateDbContext();
            return ConsultaExecucao.Filtrar(context.Execucoes.AsNoTracking(), context.Atividades, _usuario)
                             .Where(e => e.AtividadeId == atividadeId)
                             .OrderByDescending(e => e.DataInicio).ThenByDescending(e => e.Id)
                             .Select(e => new ExecucaoDTO
                             {
                                 Id = e.Id,
                                 AtividadeId = e.AtividadeId,
                                 UsuarioId = e.UsuarioId,
                                 Etapa = e.Etapa,
                                 Usuario = context.Usuarios.Where(usuario => usuario.Id == e.UsuarioId).Select(usuario => usuario.Nome).FirstOrDefault() ?? "Autoria não registrada",
                                 DataFim = e.DataFim,
                                 DataInicio = e.DataInicio
                             }).ToList();
        }
        public VisualizaExecucaoAtividadeDTO BuscarDadosAtividade(int atividadeId)
        {
            using var context = _dbContextFactory.CreateDbContext();

            var execucoes = ConsultaExecucao.Filtrar(context.Execucoes.AsNoTracking(), context.Atividades, _usuario);
            return (from a in context.Atividades.AsNoTracking()
                    join p in context.Projetos.AsNoTracking() on a.ProjetoId equals p.Id into projetos
                    from p in projetos.DefaultIfEmpty()
                    where a.Id == atividadeId && execucoes.Any(execucao => execucao.AtividadeId == a.Id)
                    select new VisualizaExecucaoAtividadeDTO
                    {
                        NomeAtividade = a.Nome,
                        DescricaoAtividade = a.Descricao,
                        DataCriacaoAtividade = a.DataCriacao,
                        NomeProjeto = p == null ? "Sem projeto" : p.Nome
                    })
                .FirstOrDefault();
        }
    }
}
