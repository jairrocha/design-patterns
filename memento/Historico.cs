using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Historico
    {
        private IList<Estado> Estados { get; set; }

        #region [Construtor]
        public Historico()
        {
            Estados = new List<Estado>();
        }
        #endregion

        public void Adiciona(Estado estado)
        {
            this.Estados.Add(estado);
        }

        public Estado Pega(int indice) => Estados[indice];
        
    }
}
