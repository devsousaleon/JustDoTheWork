using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Entity
{
    public class Execucao : BaseClass
    {
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; }
        public int AtividadeId { get; set; }
    }
}