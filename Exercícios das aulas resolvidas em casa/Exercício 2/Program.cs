using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 2---");
            int numeroTotal = 0;
            for (int i = 49; i <= 149; i++)
            {
                if (i % 2 == 0)
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
