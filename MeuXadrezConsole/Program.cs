using System;
using Tabuleiro;

namespace MeuXadrezConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posicao: " + P);

            Console.ReadLine();
        }
    }
}
