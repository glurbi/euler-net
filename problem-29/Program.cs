using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace problem_29
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<BigInteger>();
            foreach (var a in Enumerable.Range(2, 99))
            {
                foreach (var b in Enumerable.Range(2, 99))
                {
                    var x = BigInteger.Pow(a, b);
                    set.Add(x);
                }
            }
            Console.WriteLine(set.Count);
            Console.ReadLine();
        }
    }
}
