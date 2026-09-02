namespace JustDoTheWork.DTO
{
    public class DashboardProjetoTempoDTO
    {
        public string NomeProjeto { get; set; } = string.Empty;
        public int SegundosExecucao { get; set; }
        public string TempoFormatado => TimeSpan.FromSeconds(SegundosExecucao).ToString(@"hh\:mm\:ss");
    }
}
