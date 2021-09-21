using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probeli_s_vivodom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, содержащую хотя бы один пробел.");
            string stroka = Console.ReadLine();
            
            int pervii_probel = stroka.IndexOf(" ");
            int poslednii_probel = stroka.LastIndexOf(" ");

            Console.WriteLine("Вывод подстроки, расположенной между первым и последним пробелом исходной строки.");
            Console.WriteLine("Если строка содержит только один пробел, то происходит вывод пустой строки.");

            if (pervii_probel == poslednii_probel)
            {
                Console.WriteLine("    ");
            }
            else
            {
                string result = stroka.Substring(pervii_probel, stroka.Length - poslednii_probel);
               
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
    }

