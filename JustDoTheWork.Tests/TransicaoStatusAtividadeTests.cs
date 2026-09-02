using JustDoTheWork.Entity.Domains;
using Xunit;

namespace JustDoTheWork.Tests
{
    public class TransicaoStatusAtividadeTests
    {
        [Theory]
        [InlineData(StatusAtividade.Pendente, StatusAtividade.Executando, true)]
        [InlineData(StatusAtividade.Pendente, StatusAtividade.Cancelado, true)]
        [InlineData(StatusAtividade.Executando, StatusAtividade.Pausado, true)]
        [InlineData(StatusAtividade.Executando, StatusAtividade.Pendente, true)]
        [InlineData(StatusAtividade.Executando, StatusAtividade.Finalizado, true)]
        [InlineData(StatusAtividade.Pausado, StatusAtividade.Executando, true)]
        [InlineData(StatusAtividade.Pausado, StatusAtividade.Pendente, true)]
        [InlineData(StatusAtividade.Pausado, StatusAtividade.Cancelado, true)]
        public void Permitida_TransicoesValidas(StatusAtividade atual, StatusAtividade novo, bool esperado)
        {
            Assert.Equal(esperado, TransicaoStatusAtividade.Permitida(atual, novo));
        }

        [Theory]
        [InlineData(StatusAtividade.Analise, StatusAtividade.Pendente)]
        [InlineData(StatusAtividade.Analise, StatusAtividade.Executando)]
        [InlineData(StatusAtividade.Pendente, StatusAtividade.Finalizado)]
        [InlineData(StatusAtividade.Executando, StatusAtividade.Cancelado)]
        [InlineData(StatusAtividade.Finalizado, StatusAtividade.Executando)]
        [InlineData(StatusAtividade.Cancelado, StatusAtividade.Pendente)]
        [InlineData(StatusAtividade.Pendente, StatusAtividade.Pendente)]
        public void Permitida_TransicoesInvalidas(StatusAtividade atual, StatusAtividade novo)
        {
            Assert.False(TransicaoStatusAtividade.Permitida(atual, novo));
        }

        [Theory]
        [InlineData(StatusAtividade.Pendente, StatusAtividade.Executando, false)]
        [InlineData(StatusAtividade.Pausado, StatusAtividade.Executando, false)]
        [InlineData(StatusAtividade.Executando, StatusAtividade.Pausado, true)]
        [InlineData(StatusAtividade.Executando, StatusAtividade.Pendente, true)]
        [InlineData(StatusAtividade.Executando, StatusAtividade.Finalizado, true)]
        public void RequerFecharExecucao_SomenteQuandoSaiDeExecutando(StatusAtividade atual, StatusAtividade novo, bool esperado)
        {
            Assert.Equal(esperado, TransicaoStatusAtividade.RequerFecharExecucao(atual, novo));
        }
    }
}