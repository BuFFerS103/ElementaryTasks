using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Controller
    {
        public static uint SetValue()
        {
            do
            {
                try
                {
                    uint value = uint.Parse(Console.ReadLine());
                    return value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(View.ContinueRequest);
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key != ConsoleKey.Enter)
                    {
                        return 0;
                    }
                    Console.WriteLine();
                }
            } while (true);
        }

        public static char[] CreateBoard(uint rows, uint colums)
        {
            char[] chessBoard = new char[rows * colums];
            for (uint i = 0, j = 0; i < chessBoard.Length; i++)
            {
                if (i % colums == 0 && i != 0)
                {
                    j++;
                }
                if ((i + j) % 2 == 1)
                {
                    chessBoard[i] = ' ';
                }
                else
                {
                    chessBoard[i] = '*';
                }
            }
            return chessBoard;
        }

        public static bool ContinueRequest()
        {
            View.PrintContinueRequest();
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            bool proceed = keyInfo.Key == ConsoleKey.Enter;
            Console.Clear();
            return proceed;
        }
    }
}

