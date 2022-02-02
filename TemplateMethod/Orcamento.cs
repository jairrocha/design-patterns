using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public int QntdeItens { get; private set; }
        public IList<Item> Itens { get; }

        public Orcamento()
        {
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
            Valor = Itens.Sum(i => i.Valor);
            QntdeItens = Itens.Count();
        }
    }
}
