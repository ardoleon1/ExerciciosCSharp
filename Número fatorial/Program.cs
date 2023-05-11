using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número positivo: ");
            int fatorial = int.Parse(Console.ReadLine());

            if (fatorial <= 0)
            {
                Console.Write("Digite um número positivo válido: ");
                fatorial = int.Parse(Console.ReadLine());
            }

            for (int i = fatorial-1; i >= 1 ; i--)
            {
                fatorial *= i;
            }
            Console.WriteLine("O fatorial desse número é " + fatorial);
            Console.ReadLine();
        }
    }
}
