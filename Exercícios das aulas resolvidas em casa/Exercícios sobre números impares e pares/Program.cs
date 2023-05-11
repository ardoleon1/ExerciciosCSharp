using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_sobre_números_impares_e_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 1---");
            int numeroTotal = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    numeroTotal += i;
                }
            }
            Console.WriteLine("A soma total é " + numeroTotal);
            Console.ReadLine();
        }
    }
}
