using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento1 = new Orcamento();
            orcamento1.AdicionaItem(new Item("Celular", 501));
            Console.WriteLine(new CalcularDesconto(orcamento1).Desconto());


            var orcamento2 = new Orcamento();
            orcamento2.AdicionaItem(new Item("Celular", 500));
            Console.WriteLine(new CalcularDesconto(orcamento2).Desconto());


            var orcamento3 = new Orcamento();
            orcamento3.AdicionaItem(new Item("lapis", 1.00));
            orcamento3.AdicionaItem(new Item("borracha", 1.00));
            orcamento3.AdicionaItem(new Item("régua", 5.00));
            orcamento3.AdicionaItem(new Item("caderno", 15.00));
            orcamento3.AdicionaItem(new Item("corretivo", 5.00));
            orcamento3.AdicionaItem(new Item("giz", 5.00));
            Console.WriteLine(new CalcularDesconto(orcamento3).Desconto());

            var orcamento4 = new Orcamento();
            orcamento4.AdicionaItem(new Item("apontador", 1.00));
            orcamento4.AdicionaItem(new Item("borracha", 1.00));
            orcamento4.AdicionaItem(new Item("régua", 5.00));
            orcamento4.AdicionaItem(new Item("caderno", 15.00));
            orcamento4.AdicionaItem(new Item("corretivo", 5.00));
            orcamento4.AdicionaItem(new Item("giz", 5.00));
            Console.WriteLine(new CalcularDesconto(orcamento4).Desconto());
            


        }
    }
}
