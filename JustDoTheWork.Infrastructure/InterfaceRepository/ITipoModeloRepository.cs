using JustDoTheWork.DTO;

namespace JustDoTheWork.Infrastructure.InterfaceRepository
{
    public interface ITipoModeloRepository
    {
        IEnumerable<TipoModeloDTO> PesquisarParaCombo();
    }
}
