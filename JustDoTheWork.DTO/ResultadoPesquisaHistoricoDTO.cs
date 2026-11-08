namespace JustDoTheWork.DTO
{
    public class ResultadoPesquisaHistoricoDTO
    {
        public int ExecucaoId { get; set; }
        public string NomeAtividade { get; set; } = string.Empty;
        public string NomeProjeto { get; set; } = string.Empty;
        public DateTime DataInicioExecucao { get; set; }
        public DateTime? DataFimExecucao { get; set; }
        public int? UsuarioId { get; set; }
        public string Usuario { get; set; } = "Autoria não registrada";
        public JustDoTheWork.Entity.EtapaAtividade? Etapa { get; set; }
        public string NomeEtapa => Etapa.HasValue ? JustDoTheWork.Entity.FluxoAtividade.NomeEtapa(Etapa.Value) : "Etapa não registrada";
    }
}
