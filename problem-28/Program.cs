using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_28
{
    class Program
    {
        static int sum(int n)
        {
            if (n == 1)
                return 1;

            int outer = 0;
            int i = (n - 2) * (n - 2) + (n - 1);
            while (i <= n * n)
            {
                outer += i;
                i += (n - 1);
            }

            return sum(n - 2) + outer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(sum(1001));
            Console.ReadLine();
        }
    }
}
