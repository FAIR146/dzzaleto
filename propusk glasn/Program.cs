using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propusk_glasn
{
    class Program
    {
        static public int summ(string a, string b)
        {
            string strA = "";
            string strB = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsDigit(a[i]))
                {
                    strA += a[i];
                }
            }
            for (int j = 0; j < b.Length; j++)
            {
                if (char.IsDigit(b[j]))
                {
                    strB += b[j];
                }
            }
            return Convert.ToInt16(strA) + Convert.ToInt16(strB);
        }
    }
    }

