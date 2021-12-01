using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Controller controller = new Controller();
            controller.Run();
        }
    }
}
