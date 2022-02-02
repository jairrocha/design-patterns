using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Aprovado : IEstadoDeUmOrcamento
    {

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamentos aprovados não podem serem aprovados mais de uma vez");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.StatusOrcamento = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamento aprovados não podem serem reprovados.");
        }

        public override string ToString() => "Aprovado";

    }
}
