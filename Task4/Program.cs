using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @" ";
            string searchString = " ";
            string newString = " ";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error");
            }

            string text = File.ReadAllText(filePath);
            var matches = Regex.Matches(text, searchString);
            Console.WriteLine(matches.Count());

            foreach (var item in matches)
            {
                text = text.Replace(item.ToString(), newString);
                Console.WriteLine(text);
            }
            File.WriteAllText(filePath, text);
        }
    }
}
