namespace JustDoTheWork.DTO
{
    public class ResultadoPesquisaHistoricoDTO
    {
        public int ExecucaoId { get; set; }
        public string NomeAtividade { get; set; } = string.Empty;
        public string NomeProjeto { get; set; } = string.Empty;
        public DateTime DataInicioExecucao { get; set; }
        public DateTime? DataFimExecucao { get; set; }
    }
}
