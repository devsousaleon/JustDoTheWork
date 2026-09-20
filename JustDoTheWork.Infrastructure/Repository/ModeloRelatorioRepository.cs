using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ModeloRelatorioRepository : IModeloRelatorioRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;

        public ModeloRelatorioRepository(JustDoTheWorkDbContextFactory? dbContextFactory = null)
        {
            _dbContextFactory = dbContextFactory;
        }

        public string Inclusao(ModeloRelatorio modeloRelatorio)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {
                context.ModelosRelatorio.Add(modeloRelatorio);
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return "Erro ao incluir o modelo! \n" + ex.Message;
            }
        }

        public string Edicao(ModeloRelatorio modeloRelatorio)
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
                return "Erro ao editar o modelo! \n" + ex.Message;
            }
        }

        public string ExclusaoPorId(int Id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {
                var modelosRelatorio = context.ModelosRelatorio.Find(Id)!;
                context.ModelosRelatorio.Remove(modelosRelatorio);
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return "Erro ao excluir o modelo! \n" + ex.Message;
            }
        }

        public ModeloRelatorioDTO BuscarPorId(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            return context.ModelosRelatorio
                          .AsNoTracking()
                          .Where(mr => mr.Id == id)
                          .Select(mr => new ModeloRelatorioDTO
                          { 
                              Descricao = mr.Descricao,
                              Texto = mr.Texto,
                              Ativo = mr.Ativo,
                              TipoModeloId = mr.TipoModeloId
                          }).FirstOrDefault();
        }

        public byte[]? BuscaModeloHistoricoExecucao()
        {
            using var context = _dbContextFactory.CreateDbContext();

            return context.ModelosRelatorio
                          .AsNoTracking()
                          .Where(mr => mr.Ativo && mr.TipoModeloId == 1)
                          .Select(mr => mr.Texto)
                          .FirstOrDefault();
        }

        public IEnumerable<ResultadoPesquisaModeloRelatorioDTO> Pesquisar(FiltroPesquisaModeloRelatorioDTO filtroPesquisaModeloRelatorioDTO)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var modelos = context.ModelosRelatorio.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(filtroPesquisaModeloRelatorioDTO.DescricaoModelo))
                modelos = modelos.Where(mr => mr.Descricao.Contains(filtroPesquisaModeloRelatorioDTO.DescricaoModelo));

            if (filtroPesquisaModeloRelatorioDTO.TipoModelo > 0)
                modelos = modelos.Where(mr => mr.TipoModeloId == filtroPesquisaModeloRelatorioDTO.TipoModelo);

            return (from modelo in modelos
                   join tipomodelo in context.TiposModelo.AsNoTracking()
                   on modelo.TipoModeloId equals tipomodelo.Id
                   select new ResultadoPesquisaModeloRelatorioDTO
                   {
                       Id = modelo.Id,
                       Descricao = modelo.Descricao,
                       TipoModelo = tipomodelo.Descricao,
                       Ativo = modelo.Ativo
                   }).ToList();
        }
    }
}