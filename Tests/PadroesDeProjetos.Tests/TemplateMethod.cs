using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod;
using TemplateMethod.Imposto;
using Xunit;

namespace PadroesDeProjetos.Tests
{
    public class TemplateMethod
    {
        [Theory]
        [InlineData(new Item("", 100), 100)]
        public void CalculaICPP(Item item, double valorEsperado) 
        {
            //Arranje - Cenário
            var icpp = new ICPP();
            var orcamento = new Orcamento();
            var calculadora = new CalculadorDeImposto();

            orcamento.AdicionaItem(item);

            //ACT - Método sob teste

            //Assert - Resultado esperado
        }
        public void ICCV() 
        { 
        
        }

        public void ICPP()
        {

        }
    }
}
