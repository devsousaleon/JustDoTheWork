using JustDoTheWork.Entity.Domains;

namespace JustDoTheWork.DTO
{
    public class AtividadeDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public byte[] Descricao { get; set; }
        public StatusAtividade Status { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public int ProjetoId { get; set; }
    }
}