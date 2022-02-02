using Flyweight.NotasMusicais;
using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Um Flyweight serve para quando temos muitas instâncias do mesmo objeto 
                andando pelo sistema, e precisamos economizar. Para tal, o Flyweight faz 
                uso de uma fábrica modificada, que guarda essas instâncias.
                
                Note no exemplo criamos os objetos de nota apenas uma única vez. Por exemplo
                a nota 'FA' a mesma repete 3 vezes, isso não é motivo para criarmos 3 objetos
                do tipo FA



             */

            IList<INota> musica = new List<INota>()
            {
                Notas.Pega("do"),
                Notas.Pega("re"),
                Notas.Pega("mi"),
                Notas.Pega("fa"),
                Notas.Pega("fa"),
                Notas.Pega("fa"),
               

            };

            var piano = new Piano();

            piano.Toca(musica);
        }
    }
}
