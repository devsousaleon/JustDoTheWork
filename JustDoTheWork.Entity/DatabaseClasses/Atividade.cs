using System;

namespace JustDoTheWork.Entity
{
    public class Atividade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataFinalizacao { get; set; }
        public int ProjetoId { get; set; }
    }
}
