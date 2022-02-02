using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridges
{
    public class Fax : IEnviador
    {
        public void Envia(IMessagem messagem)
        {
            Console.WriteLine("Sendo enviada do FAX");
            Console.WriteLine(messagem.Formata());

        }
    }
}
