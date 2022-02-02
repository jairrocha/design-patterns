using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Exemplo
{
    public class Item
    {
       
        public string Nome { get; set; }
        public double Valor { get; set; }

        #region [Construtor]
        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
        #endregion

    }
}
 