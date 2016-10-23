using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_24
{
    class Program
    {
        static IEnumerable<string> Permutations(string elements)
        {
            if (elements.Length == 1)
                yield return elements;

            foreach (var c in elements)
            {
                var subelements = elements.Remove(elements.IndexOf(c), 1);
                var permutations = Permutations(subelements);
                foreach (var permutation in permutations)
                {
                    yield return c + permutation;
                }
            }
        }

        static void Main(string[] args)
        {
            var res = Permutations("0123456789").Skip(999999).First();
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
