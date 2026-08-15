namespace JustDoTheWork.DTO
{
    public class ModeloRelatorioDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int TipoModeloId { get; set; }
        public byte[] Texto { get; set; }
        public bool Ativo { get; set; }
    }
}