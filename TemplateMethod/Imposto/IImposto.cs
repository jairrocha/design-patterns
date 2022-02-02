using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Imposto
{
    public interface IImposto
    {
        public double Aliquota(Orcamento orcamento);
        public double ValorAdicional { get; set; }

    }
}
