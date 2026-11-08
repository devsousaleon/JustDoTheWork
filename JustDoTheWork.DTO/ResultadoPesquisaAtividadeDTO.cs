using JustDoTheWork.Entity;

namespace JustDoTheWork.DTO
{
    public class ResultadoPesquisaAtividadeDTO
    {
        public int Id { get; set; }
        public string Atividade { get; set; }
        public string Projeto { get; set; }
        public StatusAtividade Status { get; set; }
        public EtapaAtividade Etapa { get; set; }
        public int? UsuarioResponsavelId { get; set; }
        public bool RetornoExclusivo { get; set; }
        public string Responsavel { get; set; } = string.Empty;
        public string NomeEtapa => FluxoAtividade.NomeEtapa(Etapa);
    }
}
