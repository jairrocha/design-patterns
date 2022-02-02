using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.StatusOrcamento = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamentos em aprovação não podem serem finalizados.");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.StatusOrcamento = new Reprovado();
        }

        public override string ToString() => "Em Aprovação";
    }
}
