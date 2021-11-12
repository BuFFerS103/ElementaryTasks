using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed;
            do   //TODO separate main and while | add diff controllers
            {
                View.PrintGreetings();
                View.PrintInstructionMessage();

                uint rows = Controller.SetValue();
                uint columns = Controller.SetValue();
                char[] chessBoard = Controller.CreateBoard(rows, columns);
                View.DisplayChessBoard(chessBoard, rows, columns);

                proceed = Controller.ContinueRequest();

            } while (proceed);
        }
    }
}
