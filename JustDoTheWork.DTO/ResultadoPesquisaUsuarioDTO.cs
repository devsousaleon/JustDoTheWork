namespace JustDoTheWork.DTO
{
    public class ResultadoPesquisaUsuarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Logon { get; set; } = string.Empty;
        public string TipoUsuario { get; set; } = string.Empty;
    }
}
