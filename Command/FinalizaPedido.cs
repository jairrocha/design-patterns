using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class FinalizaPedido : IComando
    {
        public Pedido Pedido { get; }

        public FinalizaPedido(Pedido pedido)
        {
            Pedido = pedido;
        }


        public void Executa()
        {
            Console.WriteLine($"Finalizando o pedido do cliente {Pedido.Cliente}");
            Pedido.Finaliza();
        }
    }
}
