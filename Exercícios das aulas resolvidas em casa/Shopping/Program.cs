using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Shopping---");
            Console.Write("Digite o valor disponível: ");
            double valor = double.Parse(Console.ReadLine());
            int cont = 0, numeroCompras = 0; double valorTotal = 0;

            do
            {
                Console.WriteLine("Saldo atual: " + valor);
                Console.Write("Digite o valor da compra: ");
                int verificador = int.Parse(Console.ReadLine());

                if (verificador <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido, tente novamente.");
                }
                else if (verificador > valor)
                {
                    Console.Clear();
                    Console.WriteLine("Valor total das compras: " + valorTotal);
                    Console.WriteLine("Saldo restante: " + valor);
                    Console.WriteLine("Número de compras: " + numeroCompras);
                    cont = 1;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Compra efeituada com sucesso!");
                    valor -= verificador;
                    valorTotal += verificador;
                    numeroCompras++;
                }
            } while (cont != 1);

            Console.ReadLine();
        }
    }
}
