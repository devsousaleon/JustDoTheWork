namespace JustDoTheWork.Entity
{
    public static class FluxoAtividade
    {
        public const string Historiador = "Historiador";
        public const string Desenvolvedor = "Desenvolvedor";
        public const string QATester = "QA Tester";
        public const string TechLead = "Tech Lead";

        public static bool TipoUsuarioValido(string tipo)
            => new[] { Historiador, Desenvolvedor, QATester, TechLead }.Contains(tipo, StringComparer.OrdinalIgnoreCase);

        public static string TipoUsuarioPorEtapa(EtapaAtividade etapa)
            => etapa switch
            {
                EtapaAtividade.Historiador => Historiador,
                EtapaAtividade.Desenvolvedor => Desenvolvedor,
                EtapaAtividade.QATester => QATester,
                _ => string.Empty
            };

        public static string NomeEtapa(EtapaAtividade etapa)
            => etapa == EtapaAtividade.Finalizada ? "Finalizada" : TipoUsuarioPorEtapa(etapa);

        public static EtapaAtividade ProximaEtapa(EtapaAtividade etapa)
            => etapa switch
            {
                EtapaAtividade.Historiador => EtapaAtividade.Desenvolvedor,
                EtapaAtividade.Desenvolvedor => EtapaAtividade.QATester,
                EtapaAtividade.QATester => EtapaAtividade.Finalizada,
                _ => throw new InvalidOperationException("A atividade não possui uma próxima etapa.")
            };

        public static bool EstaAberta(StatusAtividade status)
            => status is StatusAtividade.Pendente or StatusAtividade.Executando or StatusAtividade.Pausado;

        public static bool TransicaoPermitida(StatusAtividade atual, StatusAtividade novo)
            => atual switch
            {
                StatusAtividade.Pendente => novo == StatusAtividade.Executando,
                StatusAtividade.Executando => novo is StatusAtividade.Pausado or StatusAtividade.Pendente,
                StatusAtividade.Pausado => novo is StatusAtividade.Executando or StatusAtividade.Pendente,
                _ => false
            };
    }
}
