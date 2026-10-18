using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.DTO;

public sealed class DadosImpressaoHistoricoDTO
{
    public ModeloRelatorioDTO Modelo { get; set; } = new();
    public TipoModeloDTO TipoModelo { get; set; } = new();
    public UsuarioDTO? Usuario { get; set; }
    public TipoUsuario? TipoUsuario { get; set; }
    public List<RegistroImpressaoHistoricoDTO> Registros { get; set; } = new();
}

public sealed class RegistroImpressaoHistoricoDTO
{
    public AtividadeDTO Atividade { get; set; } = new();
    public ExecucaoDTO Execucao { get; set; } = new();
    public ProjetoDTO Projeto { get; set; } = new();
}
