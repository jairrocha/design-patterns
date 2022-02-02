using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Exemplo
{
    public class ItemBuilder
    {
        private string nome { get; set; }
        private double valor { get; set; }

        public ItemBuilder ParaItem(string nome)
        {
            this.nome = nome;
            return this;
        }
        public ItemBuilder ComValor(double valor)
        {
            this.valor = valor;
            return this;
        }
        public Item Builer()
        {
            return new Item(nome, valor);
        }
    }
}
