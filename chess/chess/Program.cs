using System;
using tabuleiro;
using xadrez;
using tabuleiro.Enums;
using tabuleiro.Exceptions;

namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Tabuleiro tab = new Tabuleiro(8, 8);

                //tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                //tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                //tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                //Tela.ImprimirTabuleiro(tab);

                PosicaoXadrez pos = new PosicaoXadrez('c', 7);

                Console.WriteLine(pos.ToPosicao());

                //Console.WriteLine(pos);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
