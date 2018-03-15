using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
// There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
// How many circular primes are there below one million?

namespace problem_35
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        static int[] Rotations(int n)
        {
            var s = "" + n;
            var res = new int[s.Length];
            res[res.Length - 1] = n;

            for (int i = 0; i < s.Length-1; i++)
            {
                s = s.Substring(1) + s[0];
                res[i] = int.Parse(s);
            }

            return res;
        }


        static void Main(string[] args)
        {
            var count = 0;

            foreach (var n in Enumerable.Range(1, 1000000))
            {
                if (!IsPrime(n))
                    continue;

                var rotations = Rotations(n);

                if (rotations.All(x => IsPrime(x)))
                {
                    count++;
                    Console.WriteLine(string.Join(",", rotations));
                }
            }

            Console.WriteLine("Count = " + count);
            Console.ReadKey();
        }
    }
}
