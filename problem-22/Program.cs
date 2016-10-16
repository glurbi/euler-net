using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_22
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesRaw = Properties.Resources.names;
            var namesUnsorted = namesRaw.Split(',').Select(x => x.Substring(1, x.Length - 2));
            var names = namesUnsorted.OrderBy(x => x);
            var i = 1;
            var sum = 0;
            foreach (var name in names)
            {
                var value = Encoding.ASCII.GetBytes(name).Select(c => c - 64).Aggregate((acc, x) => acc + x);
                //Console.WriteLine(name + " " + value);
                sum += i * value;
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
