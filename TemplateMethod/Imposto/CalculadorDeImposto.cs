using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Imposto
{
    public class CalculadorDeImposto
    {
        public double RetornaImposto(Orcamento orcamento, IImposto imposto)
        {
            var aliquota = imposto.Aliquota(orcamento);
            var valorImposto = Math.Round(aliquota * orcamento.Valor, 2);

            Console.WriteLine(
                                $"Orcamento:{orcamento.Valor}\n" +
                                $"Aliquota:{aliquota}\n"+
                                $"Imposto:{valorImposto + imposto.ValorAdicional}"+
                                $"\n");

            return valorImposto;
        }

    }
}
