using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Desafio
{
    public class Conta
    {
        public IEstadoDeUmaConta EstadoConta { get; private set;}
        public double Saldo { get; private set; }

        public Conta(double valor)
        {
            Deposita(valor);
        }
        
        public void Saca(double valor)
        {
            Saldo -= valor;
            MudaEstadoConta();
        }
        
        public void Deposita(double valor)
        {
            Saldo += valor;
            MudaEstadoConta();
        }

        private void MudaEstadoConta()
        {

            if (Saldo < 0) 
                EstadoConta = new SaldoNegativo(this);
            else
                EstadoConta = new SaldoPositivo(this);
        }
    }
}
