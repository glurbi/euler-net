using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_21
{
    class Program
    {
        static Dictionary<int, int> D = new Dictionary<int, int>();

        static int d(int n)
        {
            return
                Enumerable.Range(1, n / 2)
                .Where(x => n % x == 0)
                .Aggregate((acc, x) => acc + x);
        }

        static bool amicable(int n1, int n2)
        {
            return D[n1] == n2 && n1 == D[n2];
        }

        static void Main(string[] args)
        {
            var N = 10000;
            for (int i = 3; i < N; i++)
                D[i] = d(i);

            var sum = 0;
            for (int i = 3; i < N; i++)
            {
                for (int j = 2; j < i-1; j++)
                {
                    if (amicable(i, j))
                    {
                        Console.WriteLine(i + " " + j);
                        sum += i + j;
                    }
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
