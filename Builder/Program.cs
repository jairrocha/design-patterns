using Builder.Exemplo;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var nfBuilder = new NotaFiscalBuilder()
                .ParaEmpresa("JJ S.A")
                .ComCnpj("123456")
                .ComItem(new Item("Item 1", 100))
                .ComItem(new Item("Item 2", 200))
                .ComItem(new Item("Item 3", 200))
                .ComObservacoes("Aplicando o padão builder")
                .Builder();


            Console.WriteLine($"Valor bruto:{nfBuilder.ValorBruto}\nImposto:{nfBuilder.Impostos}");
            
        }
    }
}
