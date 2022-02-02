using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Filtro
{
    public class Conta
    {
        public Conta(DateTime dataAbertura, double saldo)
        {
            DataAbertura = dataAbertura;
            Saldo = saldo;
        }

        public DateTime DataAbertura { get; set; }
        public double Saldo { get; set; }


        public override string ToString()
        {
            return $"Data:{DataAbertura} \nSaldo:{Saldo}";
        }


    }
}
