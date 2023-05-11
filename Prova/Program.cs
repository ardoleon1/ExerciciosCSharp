using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Prova---");
            int opcao; double raio, baseRetangulo, alturaRetangulo, baseTriangulo, alturaTriangulo, area;
            int repetir = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Seja bem-vindo ao programa de cálculo. O que você deseja?");
                Console.WriteLine("Escolha uma opção abaixo:");
                Console.WriteLine("[1] Calcular a área de um círculo");
                Console.WriteLine("[2] Calcular a área de um retângulo");
                Console.WriteLine("[3] Calcular a área de um triângulo");
                Console.Write("Alternativa: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("\nDigite o raio do círculo: ");
                        raio = double.Parse(Console.ReadLine());
                        area = Math.PI * raio * raio;
                        Console.WriteLine("A área do círculo: " + area);
                        break;
                    case 2:
                        Console.Write("\nDigite a base do retângulo: ");
                        baseRetangulo = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura do retângulo: ");
                        alturaRetangulo = double.Parse(Console.ReadLine());
                        area = baseRetangulo * alturaRetangulo;
                        Console.WriteLine("A área do retângulo: " + area);
                        break;
                    case 3:
                        Console.Write("\nDigite a base do triângulo: ");
                        baseTriangulo = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura do triângulo: ");
                        alturaTriangulo = double.Parse(Console.ReadLine());
                        area = (baseTriangulo * alturaTriangulo) / 2;
                        Console.WriteLine("A área do triângulo: " + area);
                        break;
                }
                Console.Write("\nDeseja repetir novamente?\n[1] para sim\n[2] para não\n");
                repetir = int.Parse(Console.ReadLine());
            } while (repetir == 1);
            Console.WriteLine("\nTenha um bom dia!");
            Console.ReadLine();

        }
    }
}
