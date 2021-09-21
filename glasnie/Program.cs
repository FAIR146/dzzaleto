using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glasnie
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "аеёиоуыэюя";

            Console.Write("Введите слово: ");
            string input = Console.ReadLine();

            foreach (char c in input)
                if (vowels.Contains(c)) { Console.ForegroundColor = ConsoleColor.Red; Console.Write(c); }
                else { Console.ForegroundColor = ConsoleColor.Gray; Console.Write(c); }

            Console.ReadKey();
        }
    }
}
