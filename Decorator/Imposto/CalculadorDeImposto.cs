using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Imposto
{
    public class CalculadorDeImposto
    {
        public double Calcula(Orcamento orcamento, Imposto imposto)
        {
            Console.WriteLine(imposto.CalculaImposto(orcamento));
            return imposto.CalculaImposto(orcamento);
        }

    }
}
