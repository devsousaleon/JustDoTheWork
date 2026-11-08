using JustDoTheWork.DTO;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class TipoModeloRepository : ITipoModeloRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;
        private readonly UsuarioSessaoDTO? _usuario;
        private static readonly ConditionalWeakTable<JustDoTheWorkDbContextFactory, CacheConsulta<TipoModeloDTO>> _cacheTiposModelo = new();

        public TipoModeloRepository(JustDoTheWorkDbContextFactory dbContextFactory, UsuarioSessaoDTO? usuario = null)
        {
            _dbContextFactory = dbContextFactory;
            _usuario = usuario;
        }

        IEnumerable<TipoModeloDTO> ITipoModeloRepository.PesquisarParaCombo()
        {
            if (_usuario?.PodeGerenciarModelos != true)
                return Array.Empty<TipoModeloDTO>();
            return _cacheTiposModelo.GetOrCreateValue(_dbContextFactory).Obter(() =>
            {
                using var context = _dbContextFactory.CreateDbContext();
                return context.TiposModelo.AsNoTracking()
                    .Select(tipo => new TipoModeloDTO
                    {
                        Id = tipo.Id,
                        Descricao = tipo.Descricao
                    }).ToList();
            }, tipo => new TipoModeloDTO { Id = tipo.Id, Descricao = tipo.Descricao });
        }
    }
}
