using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.NotasMusicais
{
    public static class Notas
    {
        private static IDictionary<string, INota> notas =
            new Dictionary<string, INota>()
            {
                {"do", new Do() },
                {"re", new Re() },
                {"mi", new Mi() },
                {"fa", new Fa() },
                {"sol", new Sol()},
                {"la", new La() },
                {"si", new Si() }

            };

        public static INota Pega(string nome)
        {
            return notas[nome];
        }
    }
}
