using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Imposto
{
    public class ImpostoAlto : Imposto
    {
        #region [Construtor]
        public ImpostoAlto(Imposto outroImposto) : base(outroImposto){}
        public ImpostoAlto(){}
        #endregion
        public override double CalculaImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + calculaOutroImposto(orcamento);
        }


    }
}
