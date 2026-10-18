namespace JustDoTheWork.Infrastructure.Repository
{
    internal sealed class CacheConsulta<T>
    {
        private readonly object _sincronizacao = new();
        private List<T>? _dados;
        private DateTime _expiracao;

        public List<T> Obter(Func<List<T>> consultar, Func<T, T> copiar)
        {
            lock (_sincronizacao)
            {
                if (_dados == null || DateTime.UtcNow >= _expiracao)
                {
                    _dados = consultar();
                    _expiracao = DateTime.UtcNow.AddMinutes(1);
                }

                // Cada tela recebe sua própria lista para não alterar os dados do cache.
                return _dados.Select(copiar).ToList();
            }
        }

        public void Invalidar()
        {
            lock (_sincronizacao)
            {
                _dados = null;
            }
        }
    }
}
