using Decorator.Filtro;
using Decorator.Imposto;
using System;
using System.Collections.Generic;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploFiltro();
            //ExemploImposto();

        }

        private static void ExemploFiltro()
        {
            var contas = new List<Conta>();
            contas.Add(new Conta(DateTime.Now, 100));
            contas.Add(new Conta(DateTime.Now.AddDays(-100), 600000));
            contas.Add(new Conta(DateTime.Now.AddDays(-100), 400000));

            var fitro = new FiltroDataAberturaMesCorrente(new FiltroSaldoMaiorQue500Mil(new FiltroSaldoMenorQue100Mil()));

            foreach (var item in fitro.Filtra(contas))
            {
                Console.WriteLine(item);
            }
        }

        private static void ExemploImposto()
        {
            var orcamento = new Orcamento(500);
            var calculadora = new CalculadorDeImposto();

            var iss = new ISS();
            var icms = new ICMS();
            var ipostoAlto = new ImpostoAlto();

            var composicao = new ISS(new ICMS(new ImpostoAlto()));

            Console.WriteLine("1) Impostos cáculados individualmente:");
            calculadora.Calcula(orcamento, iss);
            calculadora.Calcula(orcamento, icms);
            calculadora.Calcula(orcamento, ipostoAlto);

            Console.WriteLine("\n2)Composição(Somma) dos impostos:");
            calculadora.Calcula(orcamento, composicao);
        }
    }
}
