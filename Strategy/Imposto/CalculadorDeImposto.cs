using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Imposto
{
    public class CalculadorDeImposto
    {
        public double Calcula(Orcamento orcamento, IImposto imposto)
        {
            Console.WriteLine(imposto.CalculaImposto(orcamento));
            return imposto.CalculaImposto(orcamento);
        }

    }
}
