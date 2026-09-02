namespace JustDoTheWork.Entity.Domains
{
    public static class DuracaoExecucao
    {
        public static TimeSpan Calcular(DateTime inicio, DateTime? fim, DateTime agora)
        {
            var termino = fim ?? agora;
            if (termino < inicio)
                return TimeSpan.Zero;

            return termino - inicio;
        }

        public static string Formatada(TimeSpan duracao)
        {
            var totalHoras = (int)duracao.TotalHours;
            return $"{totalHoras:00}:{duracao.Minutes:00}:{duracao.Seconds:00}";
        }
    }
}
