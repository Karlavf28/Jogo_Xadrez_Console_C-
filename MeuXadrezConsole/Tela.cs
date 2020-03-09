using System;
using tabuleiro;
namespace MeuXadrezConsole
{
    class Tela
    {
        public static void  ImprimeTabuleiro(Tabuleiro tab)
        {

            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {

                    if (tab.RetornaPeca(i, j) == null)
                    {
                        Console.Write(" - ");
                    }

                    else
                    {
                        Console.Write(tab.RetornaPeca(i, j) + "x");

                    }
                }

                Console.WriteLine(" ");


            }

        }
    }
}
