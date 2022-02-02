/*
    Quando utilizar: Sempre que desejar executar tarefas posteriormente.
    No exemplo abaixo add os comandos mas os executamos de uma única vez.
 */

using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var fila = new FilaDeTrabalho();
            var pedido1 = new Pedido("Jair", 10);
            var pedido2 = new Pedido("Lidiane", 100);
            
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();

        }
    }
}
