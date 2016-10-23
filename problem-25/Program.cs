using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem_25
{
    class Program
    {
        static void Main(string[] args)
        {
            var fn2 = new BigInteger(1);
            var fn1 = new BigInteger(1);
            var fn = fn2 + fn1;
            var limit = BigInteger.Pow(new BigInteger(10), 999);
            Console.WriteLine(limit);
            var i = 3;
            while (fn < limit)
            {
                fn2 = fn1;
                fn1 = fn;
                fn = fn2 + fn1;
                i++;
                //Console.WriteLine(fn);
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
