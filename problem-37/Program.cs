using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// The number 3797 has an interesting property.Being prime itself, it is possible to continuously remove digits from left to right,
// and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.
// Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
// NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.

namespace problem_37
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

        static int[] Truncations(int n)
        {
            var s = "" + n;
            var res = new int[(s.Length - 1) * 2];

            for (int i = 0; i < s.Length - 1; i++)
            {
                res[i] = Int32.Parse(s.Substring(0, i + 1));
                res[i + s.Length - 1] = Int32.Parse(s.Substring(s.Length - 1 - i, i + 1));
            }

            return res;
        }

        static void Main(string[] args)
        {
            var sum = 0;
            var count = 0;

            foreach (int n in Enumerable.Range(10, 1000000))
            {
                if (!IsPrime(n))
                    continue;

                var truncations = Truncations(n);

                if (truncations.All(t => IsPrime(t)))
                {
                    Console.WriteLine(n + " " + string.Join(",", truncations));
                    sum += n;
                    count++;
                }
            }

            Console.WriteLine("Count: " + count);
            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();
        }
    }
}
