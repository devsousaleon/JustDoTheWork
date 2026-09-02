namespace JustDoTheWork.DTO
{
    public class AtualizaAtividadesExecucaoDTO
    {
        public int AtividadeId { get; set; }
        public string NomeAtividade { get; set; } = string.Empty;
        public string NomeProjeto { get; set; } = string.Empty;
        public int DuracaoFechadaSegundos { get; set; }
        public DateTime? InicioExecucaoAberta { get; set; }
        public int? EstimativaMinutos { get; set; }

        public TimeSpan TempoRealizado(DateTime agora)
        {
            var segundos = DuracaoFechadaSegundos;
            if (InicioExecucaoAberta.HasValue)
                segundos += (int)Math.Max(0, (agora - InicioExecucaoAberta.Value).TotalSeconds);

            return TimeSpan.FromSeconds(segundos);
        }

        public string TempoCorrido
        {
            get
            {
                var span = TempoRealizado(DateTime.Now);
                return $"{(int)span.TotalHours:00}:{span.Minutes:00}:{span.Seconds:00}";
            }
        }
    }
}
