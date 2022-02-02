using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class PagaPedido : IComando
    {
        public Pedido Pedido { get; }

        public PagaPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine($"Pagando o pedido do cliente {Pedido.Cliente}");
            Pedido.Paga();
            
        }
    }
}
