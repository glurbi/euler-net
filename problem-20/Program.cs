using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_20
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 100).Select(x => new BigInteger(x));
            var fac = numbers.Aggregate((acc, x) => acc * x);
            var sum = fac.ToString().Select(c => Char.GetNumericValue(c)).Aggregate((acc, x) => acc + x);
            Console.WriteLine(fac);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
