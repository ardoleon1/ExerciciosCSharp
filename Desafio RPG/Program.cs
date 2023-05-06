//Leonardo e Patrícia - 2ºB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Desafio RPG---");

            Random random = new Random();
            int vidaHeroi = 10, vidaMonstro = 10;
            int danoHeroi = 0, danoMonstro = 0;

            do
            {
                danoHeroi = random.Next(1, 11);
                vidaMonstro = vidaMonstro - danoHeroi;
                Console.WriteLine("O monstro foi danificado e perdeu {0} de saúde e agora tem {1} de saúde.", danoHeroi, vidaMonstro);
                if (vidaMonstro <= 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("O heroí venceu!");
                    break;
                }
                danoMonstro = random.Next(1, 11);
                vidaHeroi = vidaHeroi - danoMonstro;
                Console.WriteLine("O heroí foi danificado e perdeu {0} de saúde e agora tem {1} de saúde", danoMonstro, vidaHeroi);
                if (vidaHeroi <= 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("O monstro venceu!");
                    break;
                }
            } while (vidaHeroi > 0 && vidaMonstro > 0);

            Console.ReadLine();
        }
    }
}
