using ChainOfResponsibility.Descontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class CalcularDesconto
    {
        private  Orcamento Orcamento { get; }
        public CalcularDesconto(Orcamento orcamento)
        {
            Orcamento = orcamento;
        }

        public double Desconto()
        {
            var d1 = new DescontoValorMaiorQueQuinhentos();
            var d2 = new DescontoVendaCasada();
            var d3 = new DescontoCompraComMaisDeCincoItens();
            var d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Calcula(Orcamento);
        }
        
       

    }
}
