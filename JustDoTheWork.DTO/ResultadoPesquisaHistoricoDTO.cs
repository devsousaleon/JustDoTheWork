namespace JustDoTheWork.DTO
{
    public class ResultadoPesquisaHistoricoDTO
    {
        public string NomeAtividade { get; set; } = string.Empty;
        public string NomeProjeto { get; set; } = string.Empty;
        public DateTime DataInicioExecucao { get; set; }
        public DateTime? DataFimExecucao { get; set; }
        public int DuracaoSegundos { get; set; }
        public string Duracao
        {
            get
            {
                var span = TimeSpan.FromSeconds(DuracaoSegundos);
                return $"{(int)span.TotalHours:00}:{span.Minutes:00}:{span.Seconds:00}";
            }
        }
    }
}
