using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Imposto
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public double ValorAdicional { get; set; }

        public double Aliquota(Orcamento orcamento)
        {
            if (DeveSerMaiorAliquota(orcamento))
            {
                return MaiorAliquota(orcamento);
            }
            return MenorAliquota(orcamento);
        }

        protected abstract bool DeveSerMaiorAliquota(Orcamento orcamento);
        protected abstract double MaiorAliquota(Orcamento orcamento);
        protected abstract double MenorAliquota(Orcamento orcamento);




    }
}
