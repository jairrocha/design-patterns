﻿/* Quando usar?
 * 
 * O padrão Interpreter é geralmente útil para interpretar DSLs. 
 * É comum que, ao ler a string (como por exemplo 2+3/4), o programa 
 * transforme-a em uma estrutura de dados melhor (como as nossas classes Expressao) 
 * e aí interprete essa árvore. 
 * 
 * É realmente um padrão de projeto bem peculiar, e com utilização bem específica.
 */

using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Subtracao(new Numero(10), new Soma(new Numero(5), new Numero(1)));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));

            IExpressao conta = new Soma(esquerda, direita);

            int resultado = conta.Avalia();
            Console.WriteLine(resultado);
        }
    }
}
