using System;
using tabuleiro;
using pxadrez;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(5, 4));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(5, 2));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(5, 1));



            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
