using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Desafio
{
    class SaldoNegativo : IEstadoDeUmaConta
    {
        private readonly Conta conta;
        public SaldoNegativo(Conta conta)
        {
            this.conta = conta;
        }
        public void Deposita(double valor)
        {
            conta.Deposita(valor * 0.95);
        }

        public void Saque(double valor)
        {
            throw new InvalidOperationException("Saque não permitido");
        }

        public override string ToString() => "Saldo negativo";
    }
}
