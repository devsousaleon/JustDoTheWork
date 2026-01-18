using System;

namespace JustDoTheWork.Entity.Domains
{
    public class AtividadeFiltro
    {
        public string Nome { get; set; }
        public int? Status { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public int? ProjetoId { get; set; }
    }
}
