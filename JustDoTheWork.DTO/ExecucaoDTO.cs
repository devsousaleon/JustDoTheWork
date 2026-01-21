using System;

namespace JustDoTheWork.DTO
{
    public class ExecucaoDTO
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int AtividadeId { get; set; }
    }
}
