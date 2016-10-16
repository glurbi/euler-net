using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_23
{
    class Program
    {
        static IEnumerable<int> divisors(int n)
        {
            return
                Enumerable.Range(1, n / 2)
                .Where(x => n % x == 0);
        }

        static bool abundant(int n)
        {
            return divisors(n).Aggregate((acc, x) => acc + x) > n;
        }

        static IEnumerable<int> abundants(int N)
        {
            return Enumerable.Range(3, N-2).Where(n => abundant(n));
        }

        static void Main(string[] args)
        {
            var N = 28123;
            //var N = 100;
            var allnosum = new HashSet<int>(Enumerable.Range(1, N));
            var l = abundants(N).ToArray();
            Console.WriteLine("Number of abundant numbers 1 -> " + N  + " is " + l.Count());
            foreach (var n1 in l)
            {
                //Console.WriteLine(n1 + " => " + String.Join(" ", divisors(n1)));
                foreach (var n2 in l)
                {
                    allnosum.Remove(n1 + n2);
                }
            }
            var sum = allnosum.Sum(x => x);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
