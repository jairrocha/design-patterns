using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Desafio
{
    class SaldoPositivo : IEstadoDeUmaConta
    {
        private readonly Conta conta;
        public SaldoPositivo(Conta conta)
        {
            this.conta = conta;
        }
        public void Deposita(double valor)
        {
            conta.Deposita(valor * 0.98);
        }

        public void Saque(double valor)
        {
            conta.Saca(valor);
        }

        public override string ToString() => "Saldo positivo";
        
    }
}
