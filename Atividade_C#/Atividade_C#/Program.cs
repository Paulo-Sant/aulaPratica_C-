using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_C_
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // a) Apresentar todos os valores numéricos inteiros ímpares situados na faixa de 0 a 40.
            Console.WriteLine("a) Números ímpares de 0 a 40:");
            for (int i = 1; i <= 40; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // b) Apresentar o total da soma dos 100 primeiros números inteiros.
            Console.WriteLine("b) Soma dos 100 primeiros números inteiros:");
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine(soma + "\n");

            // c) Apresentar todos os números divisíveis por 4 que sejam menores que 40.
            Console.WriteLine("c) Números divisíveis por 4 menores que 40:");
            for (int i = 1; i < 40; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");

            // d) Apresentar os quadrados dos números inteiros de 15 a 200.
            Console.WriteLine("d) Quadrados dos números de 15 a 200:");
            for (int i = 15; i <= 200; i++)
            {
                int quadrado = i * i;
                Console.Write(quadrado + " ");
            }
            Console.WriteLine("\n");

            // e) Apresentar o resultado da soma de todos os valores pares existentes na faixa numérica de 1 a 50.
            Console.WriteLine("e) Soma dos valores pares de 1 a 50:");
            soma = 0;
            for (int i = 2; i <= 50; i += 2)
            {
                soma += i;
            }
            Console.WriteLine(soma);
        }
    }
}
