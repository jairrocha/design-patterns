using Strategy;
using System;
using Xunit;

namespace PadroesDeProjetos.Tests
{
    public class Strategy
    {
        [Theory]
        [InlineData(100, 6)]
        public void CalculaImpostoISS(double valor,double valorEsperado)
        {
            //Arranje - cenário
            var orcamento = new Orcamento(valor);
            var imposto = new ISS();
            var calc = new CalculadorDeImposto();

            //Act - método sob teste
            var result = Math.Round(calc.Calcula(orcamento, imposto), 2);

            //Assert
            Assert.Equal(valorEsperado, result);
        }

        [Theory]
        [InlineData(100, 5)]
        public void CalculaImpostoICMS(double valor, double valorEsperado)
        {
            //Arranje - cenário
            var orcamento = new Orcamento(valor);
            var imposto = new ICMS();
            var calc = new CalculadorDeImposto();

            //Act - método sob teste
            var result = Math.Round(calc.Calcula(orcamento, imposto), 2);

            //Assert
            Assert.Equal(valorEsperado, result);
        }

        [Theory]
        [InlineData(100, 5)]
        [InlineData(1500, 105)]
        [InlineData(2000, 140)]
        [InlineData(5000, 430)]
        public void CalculaImpostoICCC(double valor, double valorEsperado)
        {
            //Arranje - cenário
            var orcamento = new Orcamento(valor);
            var imposto = new ICCC();
            var calc = new CalculadorDeImposto();

            //Act - método sob teste
            var result = Math.Round(calc.Calcula(orcamento, imposto), 2);

            //Assert
            Assert.Equal(valorEsperado, result);
        }


    }
}
