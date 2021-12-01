using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task4
{
    class Parser : IDisposable
    {
        private string filePath;                                             //C:\Users\Admin\Desktop\PhoneNumbers.txt
        private string searchString;                                    
        private string newString;
        private string text;
        private string matchesCount;
        private MatchCollection matches;
        private ConsoleKeyInfo input;
        private string inputString;
        private const string ConditionToExit = "exit";

        public Parser()
        {
            Messages.PrintGreetings();
            Messages.PrintGetPath();
            filePath = Controller.SetValues();
            Messages.PrintGetText();
            searchString = Controller.SetValues();
            Messages.PrintGetTextToReplace();
            newString = Controller.SetValues();
        }

        public void ReadFile()
        {
            bool pathAccuracyError = false;
            do
            {
                try
                {
                    text = File.ReadAllText(filePath);
                    matches = Regex.Matches(text, searchString);
                    pathAccuracyError = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Messages.PrintGetPathAgain();
                    inputString = Console.ReadLine();
                    if (inputString.ToLower() == ConditionToExit)
                    {
                        Environment.Exit(0);                                            //How to exit only from main?
                    }
                    Messages.PrintGetPath();
                    filePath = Controller.SetValues();
                    pathAccuracyError = true;
                }
            } while (pathAccuracyError);
        }

        public void ChangeFile()
        {
            foreach (var item in matches)
            {
                text = text.Replace(item.ToString(), newString);
            }
        }

        public void DisplayFile()
        {
            matchesCount = matches.Count().ToString();

            Messages.PrintMatches();
            View message = new View();

            message.Display(matchesCount);
            Messages.PrintSeeResult();
            input = Console.ReadKey();
            if (input.Key == ConsoleKey.Y)
            {
                message.Display($"\n{text}");
            }

            File.WriteAllText(filePath, text);

        }  

        public void Dispose()
        {
            filePath = null;
            searchString = null;
            newString = null;
            text = null;
            matches = null;
        }

        //TODO null check
    }
}
