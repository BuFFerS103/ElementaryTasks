using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    static class Messages
    {
        private const string Greetings = "This program finds string in th file";
        public static void PrintGreetings()
        {
            Console.WriteLine(Greetings);
        }


        private const string GetPath = "Enter file location path";
        public static void PrintGetPath()
        {
            Console.WriteLine(GetPath);
        }

        private const string GetPathAgain = @"Press [Enter] and insert the correct file location path or print 'exit'  to exit";
        public static void PrintGetPathAgain()
        {
            Console.WriteLine(GetPathAgain);
        }


        private const string GetText = "Enter the text you want to find";
        public static void PrintGetText()
        {
            Console.WriteLine(GetText);
        }


        private const string GetTextToReplace = "Enter the text you want to replace on";
        public static void PrintGetTextToReplace()
        {
            Console.WriteLine(GetTextToReplace);
        }


        private const string ContinueRequest = "[Enter] to continue or any key to exit";
        public static void PrintContinueRequest()
        {
            Console.WriteLine(ContinueRequest);
        }



        private const string Matches = "Number of matches:";
        public static void PrintMatches()
        {
            Console.WriteLine(Matches);
        }

        private const string SeeResult = @"Press 'Y', if you want to see results or any key to not";
        public static void PrintSeeResult()
        {
            Console.WriteLine(SeeResult);
        }


    }
}
