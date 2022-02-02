using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Imposto
{
    public class ISS : IImposto
    {
        public double CalculaImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
