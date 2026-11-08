using System.Security.Cryptography;
using System.Text;
using JustDoTheWork.Entity.DatabaseClasses;

namespace JustDoTheWork.Infrastructure
{
    public static class RevisaoAtividade
    {
        public static string Calcular(Atividade atividade)
        {
            using var hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
            hash.AppendData(Encoding.UTF8.GetBytes($"{atividade.Nome.Length}:{atividade.Nome}|{atividade.ProjetoId}|{(int)atividade.Status}|{(int)atividade.Etapa}|{atividade.UsuarioResponsavelId}|{atividade.UltimoDesenvolvedorId}|{atividade.RetornoExclusivo}|"));
            hash.AppendData(atividade.Descricao ?? []);
            return Convert.ToHexString(hash.GetHashAndReset());
        }
    }
}
