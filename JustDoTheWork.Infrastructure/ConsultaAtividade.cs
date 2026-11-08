using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure
{
    public static class ConsultaAtividade
    {
        public static IQueryable<Atividade> Filtrar(IQueryable<Atividade> atividades, UsuarioSessaoDTO? usuario)
        {
            if (usuario == null || usuario.Id <= 0 || !FluxoAtividade.TipoUsuarioValido(usuario.TipoUsuario))
                return atividades.Where(atividade => false);

            if (usuario.EhTechLead || string.Equals(usuario.TipoUsuario, FluxoAtividade.Historiador, StringComparison.OrdinalIgnoreCase))
                return atividades;

            var etapa = string.Equals(usuario.TipoUsuario, FluxoAtividade.Desenvolvedor, StringComparison.OrdinalIgnoreCase)
                ? EtapaAtividade.Desenvolvedor : EtapaAtividade.QATester;
            return atividades.Where(atividade => atividade.Etapa == etapa &&
                ((atividade.Status == StatusAtividade.Pendente &&
                    (atividade.Etapa != EtapaAtividade.Desenvolvedor || !atividade.RetornoExclusivo || atividade.UsuarioResponsavelId == usuario.Id)) ||
                 ((atividade.Status == StatusAtividade.Executando || atividade.Status == StatusAtividade.Pausado) && atividade.UsuarioResponsavelId == usuario.Id)));
        }

        public static bool PodeEditar(Atividade atividade, UsuarioSessaoDTO? usuario)
            => usuario?.EhTechLead == true || PodeMovimentar(atividade, usuario);

        public static bool PodeCancelar(Atividade atividade, UsuarioSessaoDTO? usuario)
            => (usuario?.EhTechLead == true && FluxoAtividade.EstaAberta(atividade.Status)) || PodeMovimentar(atividade, usuario);

        public static bool PodeAssumir(Atividade atividade, UsuarioSessaoDTO? usuario)
            => usuario != null && usuario.Id > 0 && atividade.Status == StatusAtividade.Pendente &&
               atividade.Etapa is EtapaAtividade.Desenvolvedor or EtapaAtividade.QATester &&
               (atividade.Etapa != EtapaAtividade.Desenvolvedor || !atividade.RetornoExclusivo || atividade.UsuarioResponsavelId == usuario.Id) &&
               string.Equals(usuario.TipoUsuario, FluxoAtividade.TipoUsuarioPorEtapa(atividade.Etapa), StringComparison.OrdinalIgnoreCase);

        public static bool PodeMovimentar(Atividade atividade, UsuarioSessaoDTO? usuario)
            => usuario != null && usuario.Id > 0 && atividade.UsuarioResponsavelId == usuario.Id &&
               FluxoAtividade.EstaAberta(atividade.Status) &&
               (atividade.Etapa == EtapaAtividade.Historiador || atividade.Status != StatusAtividade.Pendente) &&
               string.Equals(usuario.TipoUsuario, FluxoAtividade.TipoUsuarioPorEtapa(atividade.Etapa), StringComparison.OrdinalIgnoreCase);
    }
}
