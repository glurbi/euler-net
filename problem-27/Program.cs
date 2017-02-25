using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_27
{
    class Program
    {
        static int best = 0;

        static int F(int a, int b, int n)
        {
            return n * n + a * n + b;
        }

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

        static void ConsecutivePrimes(int a, int b)
        {
            int consecutivePrimes = 0;
            for (int n = 0; n < b; n++)
            {
                var f = F(a, b, n);
                if (f > 0 && IsPrime(f))
                {
                    consecutivePrimes++;
                }
                else
                    break;
            }
            if (consecutivePrimes > best)
            {
                best = consecutivePrimes;
                Console.WriteLine("a=" + a + " b=" + b + " primes=" + consecutivePrimes + " product=" + a * b);
            }
        }

        static void Main(string[] args)
        {
            ConsecutivePrimes(1, 41);
            ConsecutivePrimes(-79,1601);
            best = 0;
            const int M = 1000;
            for (var a = 0; a < M; a++)
            {
                for (int b = 0; b < M; b++)
                {
                    ConsecutivePrimes(a, b);
                    ConsecutivePrimes(-a, b);
                    ConsecutivePrimes(a, -b);
                    ConsecutivePrimes(-a, -b);
                }
            }

            Console.ReadLine();
        }
    }
}
