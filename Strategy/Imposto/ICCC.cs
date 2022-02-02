using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Imposto
{
    public class ICCC : IImposto
    {
        public double CalculaImposto(Orcamento orcamento)
        {

            double aliquota = 0;
            double valorAdicional = 0;
            
            switch(orcamento.Valor)
            {
                case < 1000:
                    aliquota = 0.05;
                    break;
                case double v when(v >= 1000 && v <= 3000):
                     aliquota = 0.07;
                    break;
                default:
                    aliquota = 0.08;
                    valorAdicional = 30;
                    break;
            }
            return (orcamento.Valor * aliquota) + valorAdicional;
        }
    }
}
