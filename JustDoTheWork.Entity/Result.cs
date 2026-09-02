namespace JustDoTheWork.Entity
{
    public sealed class Result
    {
        public bool Sucesso { get; }
        public string Mensagem { get; }
        public Exception? Causa { get; }

        Result(bool sucesso, string mensagem, Exception? causa)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Causa = causa;
        }

        public static Result Ok() => new(true, string.Empty, null);

        public static Result Falha(string mensagem, Exception? causa = null)
            => new(false, mensagem, causa);
    }
}
