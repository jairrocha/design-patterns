using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Descontos
{
    public class DescontoValorMaiorQueQuinhentos : IDesconto
    {
        public IDesconto Proximo { get ; set; }

        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Calcula(orcamento);
        }
    }
}
