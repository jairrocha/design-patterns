using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Imposto
{
    public class IHIT : TemplateDeImpostoCondicional
    {

        protected override bool DeveSerMaiorAliquota(Orcamento orcamento)
        {
            return orcamento.Itens
                 .GroupBy(i => i.Nome)
                 .Where(grp => grp.Count() > 1)
                 .Select(grp => grp)
                 .Any();
        }

    
        protected override double MaiorAliquota(Orcamento orcamento)
        {
            ValorAdicional = 100;
            return 0.13;
        }

        protected override double MenorAliquota(Orcamento orcamento)
        {
            return 0.01 * orcamento.Itens.Count();
        }


    }
}
