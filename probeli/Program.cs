using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string words = Console.ReadLine();
            var query = from word in words.Split(' ')
                        orderby word.Length
                        select word;
            string longetWord = query.Last();
            string shortestWord = query.First();
            
            Console.WriteLine("Самое длинное слово: '{0}'. Длина: {1}",
                longetWord, longetWord.Length);
            Console.WriteLine("Самое короткое слово: '{0}'. Длина: {1}",
                shortestWord, shortestWord.Length);
            Console.ReadKey(true);
        }
    }
}
