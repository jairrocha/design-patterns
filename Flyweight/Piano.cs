using Flyweight.NotasMusicais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach (INota nota in musica)
            {
                Console.Beep(nota.Frequencia, 500);
            }

        }
    }
}
