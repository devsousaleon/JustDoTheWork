namespace JustDoTheWork.Entity.Domains
{
    public static class TransicaoStatusAtividade
    {
        public static bool Permitida(StatusAtividade atual, StatusAtividade novo)
        {
            if (atual == novo)
                return false;

            return atual switch
            {
                StatusAtividade.Pendente => novo is StatusAtividade.Executando or StatusAtividade.Cancelado,
                StatusAtividade.Executando => novo is StatusAtividade.Pausado
                    or StatusAtividade.Pendente
                    or StatusAtividade.Finalizado,
                StatusAtividade.Pausado => novo is StatusAtividade.Executando
                    or StatusAtividade.Pendente
                    or StatusAtividade.Cancelado,
                _ => false
            };
        }

        public static bool RequerNovaExecucao(StatusAtividade novo)
            => novo == StatusAtividade.Executando;

        public static bool RequerFecharExecucao(StatusAtividade atual, StatusAtividade novo)
        {
            if (atual != StatusAtividade.Executando)
                return false;

            return novo is StatusAtividade.Pausado
                or StatusAtividade.Pendente
                or StatusAtividade.Finalizado;
        }
    }
}
