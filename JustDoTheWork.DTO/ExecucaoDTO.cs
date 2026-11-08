using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.DTO
{
    public class ExecucaoDTO : Execucao
    {
        public string Usuario { get; set; } = "Autoria não registrada";
        public string NomeEtapa => Etapa.HasValue ? FluxoAtividade.NomeEtapa(Etapa.Value) : "Etapa não registrada";
    }
}
