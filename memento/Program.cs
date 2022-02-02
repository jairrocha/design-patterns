using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var contrato = new Contrato(DateTime.Now, "Fulano", TipoContrato.Novo);
            var historico = new Historico();

            contrato.Avanca();
            contrato.Avanca();
            contrato.Avanca();
                  

            Console.WriteLine(contrato.Tipo);
            
            /*Recuperando status anterior do objeto*/
            Console.WriteLine(contrato.historico.Pega(1).Contrato.Tipo) ;
        }
    }
}
