namespace JustDoTheWork.Entity.DatabaseClasses
{
    public class ModeloRelatorio
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int TipoModeloId { get; set; }
        public byte[] Texto { get; set; }
        public bool Ativo { get; set; }
    }
}