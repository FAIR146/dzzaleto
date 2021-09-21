using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klav
{
    class Program
    {
        static void Main(string[] args)
        {
            int repetitions = 0;
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();
            Console.Write("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == symbol)
                {
                    Console.Write(i + " ");
                    repetitions++;
                }
            }
            Console.WriteLine("Количество повторений заданного символа: " + repetitions);

            Console.ReadKey();
        }

    }
}
