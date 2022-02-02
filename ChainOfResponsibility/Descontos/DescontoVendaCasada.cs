using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Descontos
{
    public class DescontoVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento)
        {

            var query = orcamento.Itens
                            .Distinct()
                            .ToList()
                            .Where(i => i.Nome.ToLower() == "lapis" || 
                                    i.Nome.ToLower() == "borracha")
                            .ToList();

            if (query.Count == 2)
            {
                return orcamento.Valor * 0.05;
            }

            return Proximo.Calcula(orcamento);


        }
    }
}
