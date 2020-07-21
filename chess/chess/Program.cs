using System;
using Tabuleiro;

namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

            Console.ReadKey();
        }
    }
}
