using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orcamento finalizado não permite desconto");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamentos finalizados não podem serem aprovados.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamentos finalizados não podem serem finalizados mais de uma vez.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orçamentos finalizados não podem serem reprovados.");
        }

        public override string ToString() => "Finalizado";
    }
}
