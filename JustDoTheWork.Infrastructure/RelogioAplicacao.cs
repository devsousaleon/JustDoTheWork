namespace JustDoTheWork.Infrastructure
{
    public static class RelogioAplicacao
    {
        private static readonly TimeZoneInfo Fuso = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
        public static DateTime Agora => DateTime.SpecifyKind(TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Fuso), DateTimeKind.Unspecified);
    }
}
