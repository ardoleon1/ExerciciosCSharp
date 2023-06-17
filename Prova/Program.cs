//Uédina e Leonardo - 2ºB Informática

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Prova---");
            int opcao; double raio, baseRetangulo, alturaRetangulo, baseTriangulo, alturaTriangulo, area;
            string repetir = "S";
            do
            {
                Console.Clear();
                Console.WriteLine("Seja bem-vindo ao programa de cálculo. O que você deseja?");
                Console.WriteLine("\n[1] Para calcular área do Retângulo");
                Console.WriteLine("[2] Para calcular área do Triângulo");
                Console.WriteLine("[3] Para calcular área do Círculo");
                Console.WriteLine("[4] Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o valor da base do Retângulo: ");
                        baseRetangulo = double.Parse(Console.ReadLine());
                        if (baseRetangulo <= 0)
                        {
                            Console.WriteLine("Digite um valor válido!");
                            break;
                        }
                        Console.Write("Digite o valor da altura do Retângulo: ");
                        alturaRetangulo = double.Parse(Console.ReadLine());
                        if (alturaRetangulo <= 0)
                        {
                            Console.WriteLine("Digite um valor válido!");
                            break;
                        }
                        area = baseRetangulo * alturaRetangulo;
                        Console.WriteLine("A área do Retângulo é " + area);
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite o valor da base do Triângulo: ");
                        baseTriangulo = double.Parse(Console.ReadLine());
                        if (baseTriangulo <= 0)
                        {
                            Console.WriteLine("Digite um valor válido!");
                            break;
                        }
                        Console.Write("Digite o valor da altura do Triângulo: ");
                        alturaTriangulo = double.Parse(Console.ReadLine());
                        if (alturaTriangulo <= 0)
                        {
                            Console.WriteLine("Digite um valor válido!");
                            break;
                        }
                        area = (baseTriangulo * alturaTriangulo) / 2;
                        Console.WriteLine("A área do Triângulo é " + area);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Digite o valor do raio: ");
                        raio = double.Parse(Console.ReadLine());
                        if (raio <= 0)
                        {
                            Console.WriteLine("Digite um valor válido!");
                            break;
                        }
                        area = 3.1415 * raio * raio;
                        Console.WriteLine("A área do Círculo é " + area);
                        break;
                    case 4:
                        Console.Clear();
                        repetir = "N";
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
                if (repetir != "N")
                {
                    Console.Write("\nVocê deseja realizar uma nova operação?" +
                        "\nDigite [S] para continuar ou [N] para sair\n");
                    repetir = Console.ReadLine();
                    if (repetir != "S" && repetir != "N")
                    {
                        Console.WriteLine("Digite uma opção válida!");
                        Console.Write("\nVocê deseja realizar uma nova operação?" +
                            "\nDigite [S] para continuar ou [N] para sair\n");
                        repetir = Console.ReadLine();
                    }
                }
            } while (repetir != "N");
            Console.Clear();
            Console.WriteLine("\nTenha um bom dia!");

            Console.ReadLine();
        }
    }
}