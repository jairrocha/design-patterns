using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Orcamento
    {
        private bool descontoAplicado = false;
        public double Valor { get; set; }

        public IEstadoDeUmOrcamento StatusOrcamento { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            StatusOrcamento = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            if (descontoAplicado)
            {
                throw new InvalidOperationException("O desconto só pode ser aplicado uma única vez");
            }

            StatusOrcamento.AplicaDescontoExtra(this);
            descontoAplicado = true;
        }

        public void Aprova() => StatusOrcamento.Aprova(this);
        public void Reprova() => StatusOrcamento.Reprova(this);
        public void Finaliza() => StatusOrcamento.Finaliza(this);

    }
}
