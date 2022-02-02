using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Imposto
{
    public class ICMS : Imposto
    {

        #region [Construtores]
        public ICMS(Imposto outroImposto) : base(outroImposto){}
        public ICMS(){}
        #endregion

        public override double CalculaImposto(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + calculaOutroImposto(orcamento);
        }
    }
}
