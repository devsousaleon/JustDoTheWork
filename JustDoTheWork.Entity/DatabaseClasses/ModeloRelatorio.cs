namespace JustDoTheWork.Entity.DatabaseClasses
{
    public class ModeloRelatorio : BaseClass
    {
        public string Descricao { get; set; }
        public int TipoModeloId { get; set; }
        public byte[] Texto { get; set; }
        public bool Ativo { get; set; }
    }
}
