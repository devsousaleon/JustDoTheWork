using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure
{
    public static class ConsultaExecucao
    {
        public static IQueryable<Execucao> Filtrar(IQueryable<Execucao> execucoes, IQueryable<Atividade> atividades, UsuarioSessaoDTO? usuario)
        {
            if (usuario == null || usuario.Id <= 0 || !FluxoAtividade.TipoUsuarioValido(usuario.TipoUsuario))
                return execucoes.Where(execucao => false);
            if (usuario.EhTechLead || string.Equals(usuario.TipoUsuario, FluxoAtividade.Historiador, StringComparison.OrdinalIgnoreCase))
                return execucoes;
            return execucoes.Where(execucao => execucao.UsuarioId == usuario.Id ||
                (execucao.UsuarioId == null && atividades.Any(atividade => atividade.Id == execucao.AtividadeId && atividade.UsuarioResponsavelId == usuario.Id)));
        }
    }
}
