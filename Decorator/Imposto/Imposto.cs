using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Imposto
{
    public abstract class Imposto
    {
        private readonly Imposto OutroImposto;
        public abstract double CalculaImposto(Orcamento orcamento);

        #region [Construtores]
        protected Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }
        #endregion

        protected double calculaOutroImposto(Orcamento orcamento)
        {
            return (OutroImposto == null ? 0 : OutroImposto.CalculaImposto(orcamento));
        }

    }
}
