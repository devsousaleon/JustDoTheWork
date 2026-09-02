using JustDoTheWork.Entity.Domains;
using Xunit;

namespace JustDoTheWork.Tests
{
    public class DuracaoExecucaoTests
    {
        [Fact]
        public void Calcular_ComFimRetornaDiferenca()
        {
            var inicio = new DateTime(2026, 9, 1, 10, 0, 0);
            var fim = new DateTime(2026, 9, 1, 12, 30, 15);

            var duracao = DuracaoExecucao.Calcular(inicio, fim, DateTime.Now);

            Assert.Equal(new TimeSpan(2, 30, 15), duracao);
        }

        [Fact]
        public void Calcular_SemFimUsaHorarioAtual()
        {
            var inicio = new DateTime(2026, 9, 1, 10, 0, 0);
            var agora = new DateTime(2026, 9, 1, 10, 45, 0);

            var duracao = DuracaoExecucao.Calcular(inicio, null, agora);

            Assert.Equal(new TimeSpan(0, 45, 0), duracao);
        }

        [Fact]
        public void Calcular_FimAntesDoInicioRetornaZero()
        {
            var inicio = new DateTime(2026, 9, 1, 12, 0, 0);
            var fim = new DateTime(2026, 9, 1, 11, 0, 0);

            var duracao = DuracaoExecucao.Calcular(inicio, fim, DateTime.Now);

            Assert.Equal(TimeSpan.Zero, duracao);
        }

        [Theory]
        [InlineData(0, 0, 0, "00:00:00")]
        [InlineData(2, 5, 7, "02:05:07")]
        [InlineData(10, 9, 8, "10:09:08")]
        [InlineData(30, 0, 30, "30:00:30")]
        public void Formatada_FormataHorasMinutosSegundos(int horas, int minutos, int segundos, string esperado)
        {
            var duracao = new TimeSpan(horas, minutos, segundos);

            Assert.Equal(esperado, DuracaoExecucao.Formatada(duracao));
        }
    }
}