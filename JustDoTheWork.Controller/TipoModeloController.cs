using JustDoTheWork.DTO;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class TipoModeloController
    {
        private readonly ITipoModeloRepository _repository; 

        public TipoModeloController(ITipoModeloRepository tipoModeloRepository)
        {
            _repository = tipoModeloRepository;
        }

        public IEnumerable<TipoModeloDTO> PesquisarParaCombo()
        {
            var resultado = _repository.PesquisarParaCombo();

            return resultado.Select(m => new TipoModeloDTO
            {
                Id = m.Id,
                Descricao = m.Descricao
            });
        }
    }
}
