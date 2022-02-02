using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Subtracao(new Numero(10), new Soma(new Numero(5), new Numero(1)));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));

            IExpressao conta = new Soma(esquerda, direita);

            Impressora impressora = new Impressora();

            conta.Aceita(impressora);
            
        }
    }
}
