using System;

namespace JustDoTheWork.Entity
{
    public class Execucao
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; }
        public int AtividadeId { get; set; }
    }
}
