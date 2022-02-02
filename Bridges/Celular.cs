using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridges
{
    class Celular : IEnviador
    {
        public void Envia(IMessagem messagem)
        {
            Console.WriteLine("Enviando menssagem do Celular");
            Console.WriteLine(messagem.Formata());
            
        }
    }
}
