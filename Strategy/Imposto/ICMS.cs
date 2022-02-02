using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Imposto
{
    public class ICMS : IImposto
    {
        public double CalculaImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
