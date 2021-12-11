using Service;
using System;
using Xunit;

namespace Testes
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 2, 5)]
        public void Soma_Teste(int a, int b, int resultado)
        {
            var calculadora = new CalculadoraService();
            var soma = calculadora.Soma(a, b);

            Assert.Equal(resultado, soma);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(2, 2, 0)]
        [InlineData(3, 2, 1)]
        public void Subtracao_Teste(int a, int b, int resultado)
        {
            var calculadora = new CalculadoraService();
            var subtracao = calculadora.Subtracao(a, b);

            Assert.Equal(resultado, subtracao);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 2, 6)]
        public void Produto_Teste(int a, int b, int resultado)
        {
            var calculadora = new CalculadoraService();
            var produto = calculadora.Produto(a, b);

            Assert.Equal(resultado, produto);
        }
    }
}
