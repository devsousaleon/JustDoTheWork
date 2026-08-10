namespace JustDoTheWork.DTO
{
    public class ResultadoPesquisaHistoricoDTO
    {
        public string NomeAtividade { get; set; } = string.Empty;
        public string NomeProjeto { get; set; } = string.Empty;
        public DateTime DataInicioExecucao { get; set; }
        public DateTime DataFimExecucao { get; set; }
    }
}