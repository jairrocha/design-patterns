using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orcamento reprovado não permite desconto.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamentos reprovados não podem serem aprovados.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.StatusOrcamento = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamentos reprovados não podem serem repovados mais de uma vez.");
        }

        public override string ToString() => "Reprovado";
    }
}
