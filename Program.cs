using System;
using tabuleiro;
namespace jogo_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            p = new Posicao(3, 4);
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
