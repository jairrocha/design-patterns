using State.Desafio;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo();

            Desafio();

        }

        private static void Desafio()
        {
            try
            {
                var conta = new Conta(100);
                Console.WriteLine($"Saldo: {conta.Saldo} \nStatus: {conta.EstadoConta}");
                conta.EstadoConta.Saque(200);
                conta.EstadoConta.Deposita(100);
                Console.WriteLine($"Saldo: {conta.Saldo} \nStatus: {conta.EstadoConta}");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        private static void Exemplo()
        {
            try
            {

                var reforma = new Orcamento(100);
                reforma.AplicaDescontoExtra();
                Console.WriteLine($"Status:{reforma.StatusOrcamento} \nDesconto:{reforma.Valor}");

                reforma.Reprova();
                reforma.AplicaDescontoExtra();
                Console.WriteLine($"Status:{reforma.StatusOrcamento} \nDesconto:{reforma.Valor}");

                reforma.Finaliza();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
