using System;

namespace JustDoTheWork.Entity.Domains
{
    public class ExecucaoFilter
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int AtividadeId { get; set; }
    }
}
