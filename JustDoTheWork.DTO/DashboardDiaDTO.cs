namespace JustDoTheWork.DTO
{
    public class DashboardDiaDTO
    {
        public int AtividadesFinalizadas { get; set; }
        public int SegundosEmExecucao { get; set; }
        public int IntervalosFechados { get; set; }
        public string TempoExecucaoFormatado => TimeSpan.FromSeconds(SegundosEmExecucao).ToString(@"hh\:mm\:ss");
    }
}
