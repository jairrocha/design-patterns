using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Descontos
{
    public interface IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Calcula(Orcamento orcamento);
    }
}
