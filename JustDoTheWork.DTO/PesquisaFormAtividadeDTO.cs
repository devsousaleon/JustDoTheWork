using System;

namespace JustDoTheWork.DTO
{
    public class PesquisaFormAtividadeDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public int ProjetoId { get; set; }
    }
}
