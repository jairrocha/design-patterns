using Strategy.Imposto;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var icms = new ICMS();
            var iss = new ISS();
            var iccc = new ICCC();
            var orcamento = new Orcamento(3001);
            var calculadora = new CalculadorDeImposto();

            calculadora.Calcula(orcamento, iss);
            calculadora.Calcula(orcamento, icms);
            calculadora.Calcula(orcamento, iccc);

            Console.ReadKey();

        }
    }
}
