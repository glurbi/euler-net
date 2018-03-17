using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
// Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
// (Please note that the palindromic number, in either base, may not include leading zeros.)


namespace problem_36
{
    class Program
    {
        static bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length/2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }

            return true;
        }

        static string Base10(int n)
        {
            return "" + n;
        }

        static string Base2(int n)
        {
            return Convert.ToString(n, 2);
        }

        static void Main(string[] args)
        {
            var sum = 0;

            foreach (var n in Enumerable.Range(0, 1000000))
            {
                var b10 = IsPalindrome(Base10(n));
                var b2 = IsPalindrome(Base2(n));

                if (b10 && b2)
                {
                    Console.WriteLine(Base10(n) + ", " + Base2(n));
                    sum += n;
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
