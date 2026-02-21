using System;

namespace JustDoTheWork.Entity.Domains
{
    public class ExecucaoFilter
    {
        public int AtividadeId { get; set; }
        public string NomeAtividade { get; set; }
        public string NomeProjeto { get; set; }
        public byte[] DescricaoAtividade { get; set; }
        public DateTime DataCriacaoAtividade { get; set; }
        public DateTime DataInicioExecucao { get; set; }
        public DateTime DataFimExecucao { get; set; }
    }
}
