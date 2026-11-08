using JustDoTheWork.Entity;

namespace JustDoTheWork.DTO
{
    public class UsuarioSessaoDTO
    {
        public int Id { get; init; }
        public string Nome { get; init; } = string.Empty;
        public int TipoUsuarioId { get; init; }
        public string TipoUsuario { get; init; } = string.Empty;
        public bool EhTechLead => string.Equals(TipoUsuario, FluxoAtividade.TechLead, StringComparison.OrdinalIgnoreCase);
        public bool PodeGerenciarModelos => Id > 0 && (EhTechLead || string.Equals(TipoUsuario, FluxoAtividade.Historiador, StringComparison.OrdinalIgnoreCase));
    }
}
