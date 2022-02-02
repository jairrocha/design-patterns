using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Impressora: IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            // imprime esquerda
            soma.Esquerda.Aceita(this);
            Console.Write(" + ");
            // imprime direita
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            // imprime esquerda
            subtracao.Esquerda.Aceita(this);
            Console.Write(" - ");
            // imprime direita
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            // imprime o valor do número
            Console.Write(numero.Valor);
        }
    }
}
