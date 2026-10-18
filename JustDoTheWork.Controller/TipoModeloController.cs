using JustDoTheWork.DTO;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class TipoModeloController
    {
        private readonly ITipoModeloRepository _tipoModeloRepository;

        public TipoModeloController(ITipoModeloRepository repository)
        {
            _tipoModeloRepository = repository;
        }

        public IEnumerable<TipoModeloDTO> PesquisarParaCombo()
            => _tipoModeloRepository.PesquisarParaCombo();
    }
}
