using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Imposto
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public double Aliquota(Orcamento orcamento)
        {
            if (DeveSerMaiorAliquota(orcamento))
            {
               return MaiorAliquota(orcamento);
            }

            return MenorAliquota(orcamento);
        }

        protected override bool DeveSerMaiorAliquota(Orcamento orcamento) => 
            orcamento.Valor >= 500;
        protected override double MaiorAliquota(Orcamento orcamento) => 0.07;
        protected override double MenorAliquota(Orcamento orcamento) => 0.05;
    }
}
