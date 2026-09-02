namespace JustDoTheWork.Entity.Domains
{
    public static class FiltroDataDia
    {
        public static (DateTime Inicio, DateTime FimExclusivo) Intervalo(DateTime data)
        {
            var inicio = data.Date;
            return (inicio, inicio.AddDays(1));
        }
    }
}
