using Observer.Exemplo;
using System;

namespace Observer
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
                .AdicionaAcao(new EnviaEmail())
                .AdicionaAcao(new PersisteBd())
                .Builder();


            Console.WriteLine($"Valor bruto:{nfBuilder.ValorBruto}\nImposto:{nfBuilder.Impostos}");
        }
    }
}
