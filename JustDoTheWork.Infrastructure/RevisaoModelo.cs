using System.Security.Cryptography;
using System.Text;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure
{
    public static class RevisaoModelo
    {
        public static string Calcular(ModeloRelatorio modelo)
        {
            using var hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
            hash.AppendData(Encoding.UTF8.GetBytes($"{modelo.Id}|{modelo.Descricao.Length}:{modelo.Descricao}|{modelo.TipoModeloId}|{modelo.Ativo}|"));
            hash.AppendData(modelo.Texto ?? []);
            return Convert.ToHexString(hash.GetHashAndReset());
        }
    }
}
