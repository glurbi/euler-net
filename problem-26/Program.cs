using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem_26
{
    class Program
    {
        static bool IsCycle(string pattern, string s)
        {
            for (var i = 0; i < pattern.Length; i++)
            {
                var repeat = s.Length / pattern.Length;

                if (repeat < 2)
                    return false;

                for (var j = 1; j < repeat; j++)
                {
                    if (s[j*pattern.Length+i] != pattern[i])
                        return false;
                }
            }
            return true;
        }

        static int CycleLength(string s, int d)
        {
            for (var i = 0; i < s.Length; i++)
            {
                for (var j = 1; j < s.Length/2-i; j++)
                {
                    var pattern = s.Substring(i, j);
                    if (IsCycle(pattern, s.Substring(i, s.Length - i)))
                    {
                        Console.WriteLine($"1/{d} => 0.{s.Substring(0, i)}({pattern})");
                        return pattern.Length;
                    }
                }
            }
            throw new InvalidOperationException();
        }

        static void Main(string[] args)
        {
            var one = BigInteger.Pow(10, 2000);
            var longest = 0;
            var best_d = 0;
            for (var d = 2; d < 1000; d++)
            {
                var div = one / d;
                if (div * d == one)
                    continue;

                var length = CycleLength(div.ToString(), d);
                if (length > longest)
                {
                    longest = length;
                    best_d = d;
                }
            }
            Console.WriteLine(best_d);
            Console.ReadLine();
        }
    }
}
