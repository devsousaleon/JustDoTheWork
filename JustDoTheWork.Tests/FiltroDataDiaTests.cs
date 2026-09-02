using JustDoTheWork.Entity.Domains;
using Xunit;

namespace JustDoTheWork.Tests
{
    public class FiltroDataDiaTests
    {
        [Fact]
        public void Intervalo_RetornaDiaInteiroAteMeiaNoite()
        {
            var data = new DateTime(2026, 9, 1, 15, 30, 45);

            var (inicio, fim) = FiltroDataDia.Intervalo(data);

            Assert.Equal(new DateTime(2026, 9, 1), inicio);
            Assert.Equal(new DateTime(2026, 9, 2), fim);
        }
    }
}