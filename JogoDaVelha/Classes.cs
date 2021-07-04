using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Classes
    {
        public static void PrintarJogo(string[,] tabuleiro)
        {
            Console.WriteLine("   1 2 3");
            Console.WriteLine("1: " + tabuleiro[0, 0] + "|" + tabuleiro[0, 1] + "|" + tabuleiro[0, 2]);
            Console.WriteLine("   -----");
            Console.WriteLine("2: " +tabuleiro[1, 0] + "|" + tabuleiro[1, 1] + "|" + tabuleiro[1, 2]);
            Console.WriteLine("   -----");
            Console.WriteLine("3: " +tabuleiro[2, 0] + "|" + tabuleiro[2, 1] + "|" + tabuleiro[2, 2]);
        }

        public static bool TerminoJogo(string[,] tabuleiro)
        {
            bool termino = true;
            if (tabuleiro [0,0] != " " && tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 0] == tabuleiro[0, 2])
                termino = true;
            else if (tabuleiro[0, 0] != " " && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[0, 0] == tabuleiro[2, 2])
                termino = true;
            else if (tabuleiro[0, 0] != " " && tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[0, 0] == tabuleiro[2, 0])
                termino = true;
            else if (tabuleiro[0, 1] != " " && tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[0, 1] == tabuleiro[2, 1])
                termino = true;
            else if (tabuleiro[0, 2] != " " && tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[0, 2] == tabuleiro[2, 2])
                termino = true;
            else if (tabuleiro[0, 2] != " " && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[0, 2] == tabuleiro[2, 0])
                termino = true;
            else if (tabuleiro[1, 0] != " " && tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 0] == tabuleiro[1, 2])
                termino = true;
            else if (tabuleiro[2, 0] != " " && tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 0] == tabuleiro[2, 2])
                termino = true;
            else
                termino = false;
            
            return termino;
        }

        public static bool Empate(string[,] tabuleiro)
        {
            bool empate = true;
            for (int i = 0; i < tabuleiro.Length/3; i++)
            {
                for (int x = 0; x < tabuleiro.Length/3; x++)
                {
                    if (tabuleiro[i, x] == " ")
                        empate = false;
                }
            }

            if (TerminoJogo(tabuleiro) == true)
                empate = false;

            return empate;
        }
    }
}
