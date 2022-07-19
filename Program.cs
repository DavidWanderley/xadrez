using System;
using tabuleiro;
using pxadrez;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(6, 2));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 2));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 1));

                Tela.imprimirTabuleiro(tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
