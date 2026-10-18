using JustDoTheWork.Entity;

namespace JustDoTheWork.DTO
{
    public class ResultadoPesquisaAtividadeDTO
    {
        public int Id { get; set; }
        public string Atividade { get; set; }
        public string Projeto { get; set; }
        public StatusAtividade Status { get; set; }
    }
}
