using System;

namespace JustDoTheWork.DTO
{
    public class AtividadePesquisaDTO
    {
        public string Nome { get; set; }
        public int? ProjetoId { get; set; }
        public int? Status { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
    }
}
