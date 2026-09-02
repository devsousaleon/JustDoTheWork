namespace JustDoTheWork.DTO
{
    public class ExecucaoDTO
    {
        public int AtividadeId { get; set; }
        public DateTime? DataFimExecucao { get; set; }
        public DateTime DataInicioExecucao { get; set; }

        public string Duracao
        {
            get
            {
                var fim = DataFimExecucao ?? DateTime.Now;
                var span = fim < DataInicioExecucao ? TimeSpan.Zero : fim - DataInicioExecucao;
                return $"{(int)span.TotalHours:00}:{span.Minutes:00}:{span.Seconds:00}";
            }
        }
    }
}
