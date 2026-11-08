using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.DTO
{
    public class AtividadeDTO : Atividade
    {
        public string Responsavel { get; set; } = string.Empty;
        public string Revisao { get; set; } = string.Empty;
        public bool TemExecucoes { get; set; }
    }
}
