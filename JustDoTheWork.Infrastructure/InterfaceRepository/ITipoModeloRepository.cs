using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface ITipoModeloRepository
    {
        IEnumerable<TipoModelo> PesquisarParaCombo();
    }
}