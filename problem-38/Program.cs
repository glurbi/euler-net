using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_38
{
    class Program
    {
        static string ConcatenatedProduct(int n, int f)
        {
            var s = "";

            for (int i = 1; i <= f; i++)
            {
                s += n * i;

                if (s.Length > 9)
                    return "0";
            }

            if (s.Length < 9)
                return "0";

            return s;
        }

        static bool IsPandigital(string s)
        {
            var digits = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            foreach (var d in digits)
            {
                if (!s.Contains(d))
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(ConcatenatedProduct(192, 3));
            //Console.WriteLine(ConcatenatedProduct(9, 5));
            //Console.WriteLine(IsPandigital("192384576"));
            //Console.WriteLine(IsPandigital("192384577"));
            var max = 0;
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    var cp = ConcatenatedProduct(j, i);
                    var pandigital = IsPandigital(cp);

                    var p = Int32.Parse(cp);

                    if (IsPandigital(cp) && p > max)
                    {
                        max = p;
                        Console.WriteLine($"{max} ({j},{i})");
                    }
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
