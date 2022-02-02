using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Imposto
{
    public class ISS : Imposto
    {
        #region [Construtores]
        public ISS(Imposto outroImposto) : base(outroImposto){}
        public ISS(){}
        #endregion

        public override double CalculaImposto(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.06) + calculaOutroImposto(orcamento) ;
        }

  
    }
}
