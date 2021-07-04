using System;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabuleiro = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };

            Console.WriteLine("Seja bem vindo ao jogo da velha!");
            Classes.PrintarJogo(tabuleiro);

            while (Classes.TerminoJogo(tabuleiro) != true && Classes.Empate(tabuleiro) != true)
            {
                // Vez do jogador
                Console.WriteLine("Digite a posição que ira jogar(Linha,Coluna)");
                string[] posicao = Console.ReadLine().Split(",");
                bool validPos1 = int.TryParse(posicao[0], out int posicao1);
                bool validPos2 = int.TryParse(posicao[1], out int posicao2);

                // Impede valores diferentes de números
                while (validPos1 == false || validPos2 == false)
                {
                    Console.WriteLine("Jogada invalida! Digite uma pposição válida!");
                    posicao = Console.ReadLine().Split(",");
                    validPos1 = int.TryParse(posicao[0], out posicao1);
                    validPos2 = int.TryParse(posicao[1], out posicao2);
                }

                posicao1 = int.Parse(posicao[0]) - 1;
                posicao2 = int.Parse(posicao[1]) - 1;

                // Impede valores que ultrapassem a matriz
                while ((posicao1 >= 3 || posicao1 < 0) || (posicao2 >= 3 || posicao1 < 0))
                {
                    Console.WriteLine("Jogada invalida! Digite uma posição válida!");
                    posicao = Console.ReadLine().Split(",");
                    validPos1 = int.TryParse(posicao[0], out posicao1);
                    validPos2 = int.TryParse(posicao[1], out posicao2);

                    while (validPos1 == false || validPos2 == false)
                    {
                        Console.WriteLine("Jogada invalida! Digite uma pposição válida!");
                        posicao = Console.ReadLine().Split(",");
                        validPos1 = int.TryParse(posicao[0], out posicao1);
                        validPos2 = int.TryParse(posicao[1], out posicao2);
                    }

                    posicao1 = int.Parse(posicao[0]) - 1;
                    posicao2 = int.Parse(posicao[1]) - 1;
                }

                while (tabuleiro[posicao1, posicao2] != " ")
                {
                    Console.WriteLine("Jogada invalida! Digite uma posição válida!");
                    posicao = Console.ReadLine().Split(",");
                    validPos1 = int.TryParse(posicao[0], out posicao1);
                    validPos2 = int.TryParse(posicao[1], out posicao2);

                    while (validPos1 == false || validPos2 == false)
                    {
                        Console.WriteLine("Jogada invalida! Digite uma pposição válida!");
                        posicao = Console.ReadLine().Split(",");
                        validPos1 = int.TryParse(posicao[0], out posicao1);
                        validPos2 = int.TryParse(posicao[1], out posicao2);
                    }

                    posicao1 = int.Parse(posicao[0]) - 1;
                    posicao2 = int.Parse(posicao[1]) - 1;
                }

                tabuleiro[posicao1, posicao2] = "O";

                // Vez da maquina
                if (Classes.TerminoJogo(tabuleiro) != true && Classes.Empate(tabuleiro) != true)
                {
                    Random rnd = new();

                    while (tabuleiro[posicao1, posicao2] != " ")
                    {
                        posicao1 = rnd.Next(3);
                        posicao2 = rnd.Next(3);
                    }
                    tabuleiro[posicao1, posicao2] = "X";
                    Classes.PrintarJogo(tabuleiro);

                    if (Classes.TerminoJogo(tabuleiro) == true)
                        Console.WriteLine("Infelizmente você perdeu! :(");
                }
                else
                {
                    Classes.PrintarJogo(tabuleiro);
                    if (Classes.Empate(tabuleiro) == true)
                        Console.WriteLine("EMPATE!");
                    else
                        Console.WriteLine("Parabens, você venceu!");
                }
            }

        }
    }
}
