using System;
using TemplateMethod.Imposto;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var icpp = new ICPP();
            var ickv = new IKCV();
            var ihit = new IHIT();
            
            var orcamento1 = new Orcamento();
            var orcamento2 = new Orcamento();
            var orcamento3 = new Orcamento();
            var orcamento4 = new Orcamento();

            var calculadora = new CalculadorDeImposto();

            orcamento1.AdicionaItem(new Item("Fogao", 1000));
            orcamento2.AdicionaItem(new Item("Panela", 100));
            
            orcamento3.AdicionaItem(new Item("item 1", 100));
            orcamento3.AdicionaItem(new Item("item 1", 100));
            orcamento3.AdicionaItem(new Item("item 3", 100));
            orcamento3.AdicionaItem(new Item("item 4", 100));
            orcamento3.AdicionaItem(new Item("item 5", 100));
            orcamento3.AdicionaItem(new Item("item 6", 100));

            orcamento4.AdicionaItem(new Item("item 1", 100));
            orcamento4.AdicionaItem(new Item("item 2", 100));
            orcamento4.AdicionaItem(new Item("item 3", 100));
            orcamento4.AdicionaItem(new Item("item 4", 100));
            orcamento4.AdicionaItem(new Item("item 5", 100));
            orcamento4.AdicionaItem(new Item("item 6", 101));


            Console.WriteLine("ICPP");
            calculadora.RetornaImposto(orcamento1, icpp);
            calculadora.RetornaImposto(orcamento2, icpp);
            calculadora.RetornaImposto(orcamento3, icpp);

            Console.WriteLine("\nIKVC");
            calculadora.RetornaImposto(orcamento1, ickv);
            calculadora.RetornaImposto(orcamento2, ickv);
            calculadora.RetornaImposto(orcamento3, ickv);
            calculadora.RetornaImposto(orcamento4, ickv);

            Console.WriteLine("\nIHIT");
            calculadora.RetornaImposto(orcamento3, ihit);
            calculadora.RetornaImposto(orcamento4, ihit);




        }
    }
}
