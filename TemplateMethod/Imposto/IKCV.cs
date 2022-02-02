using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Imposto
{
    public class IKCV : IImposto
    {
        public double ValorAdicional {get; set; }

        public double Aliquota(Orcamento orcamento)
        {
            if (orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento))
            {
                return 0.10;
            }

            return 0.06;
        }

        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento) =>
                        orcamento.Itens.Where(i => i.Valor > 100).ToList().Any();
    }

}
