using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Exemplo
{
    public class EnviaEmail : IAcaoAposCriacaoNF
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("E-mail enviado.");
        }
    }
}
