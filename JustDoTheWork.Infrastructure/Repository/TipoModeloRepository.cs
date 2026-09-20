using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class TipoModeloRepository : ITipoModeloRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;

        public TipoModeloRepository(JustDoTheWorkDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        IEnumerable<TipoModelo> ITipoModeloRepository.PesquisarParaCombo()
        {
            using var context = _dbContextFactory.CreateDbContext();
            return context.TiposModelo.AsNoTracking().ToList();
        }
    }
}
