using JustDoTheWork.Entity;

namespace JustDoTheWork.Entity.DatabaseClasses
{
    public class Atividade : BaseClass
    {
        public string Nome { get; set; }
        public byte[]? Descricao { get; set; }
        public StatusAtividade Status { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataFinalizacao { get; set; }
        public int? ProjetoId { get; set; }
        public EtapaAtividade Etapa { get; set; } = EtapaAtividade.Historiador;
        public int? UsuarioResponsavelId { get; set; }
        public int? UltimoDesenvolvedorId { get; set; }
        public bool RetornoExclusivo { get; set; }
    }
}
