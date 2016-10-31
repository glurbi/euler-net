using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_27
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n == 1)
                return false;

            if (n == 2)
                return true;

            for (int i = 3; i < Math.Sqrt(n); i += 2)
            {

            }
        }

        static void Main(string[] args)
        {
        }
    }
}
