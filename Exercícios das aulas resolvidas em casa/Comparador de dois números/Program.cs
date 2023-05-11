using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparador_de_dois_números
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Comparador de dois números---");
            Console.Write("Digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());
            int cont = 0;

            while (cont != 4)
            {
                Console.WriteLine("\nSeja bem-vindo ao Comparador de dois números!\nO que você deseja?");
                Console.WriteLine("\n[1] Verificar qual é o maior número");
                Console.WriteLine("[2] Verificar qual é o menor número");
                Console.WriteLine("[3] Verificar se são iguais ou diferentes");
                Console.WriteLine("[4] Sair");
                cont = int.Parse(Console.ReadLine());

                if (cont == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Valores: " + primeiroNumero + " e " + segundoNumero);
                    if (primeiroNumero == segundoNumero)
                    {
                        Console.WriteLine("Ambos os valores são iguais.");
                    } 
                    else if (primeiroNumero > segundoNumero)
                    {
                        Console.WriteLine("O primeiro número é maior.");
                    }
                    else
                    {
                        Console.WriteLine("O segundo número é maior.");
                    }
                }
                else if (cont == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Valores: " + primeiroNumero + " e " + segundoNumero);
                    if (primeiroNumero == segundoNumero)
                    {
                        Console.WriteLine("Ambos os valores são iguais.");
                    }
                    else if (primeiroNumero < segundoNumero)
                    {
                        Console.WriteLine("O primeiro número é menor.");
                    }
                    else
                    {
                        Console.WriteLine("O segundo número é menor.");
                    }
                }
                else if (cont == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Valores: " + primeiroNumero + " e " + segundoNumero);
                    if (primeiroNumero == segundoNumero)
                    {
                        Console.WriteLine("Ambos os valores são iguais.");
                    }
                    else
                    {
                        Console.WriteLine("Ambos os valores são diferentes.");
                    }
                }
            }
            Console.WriteLine("\nTenha um ótimo dia!");
            Console.ReadLine();
        }
    }
}
