using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
// Find the sum of all numbers which are equal to the sum of the factorial of their digits.
// Note: as 1! = 1 and 2! = 2 are not sums they are not included.

namespace problem_34
{
    class Program
    {

        static int FillDigits(int number, int[] digits)
        {
            var n = number;
            int i = 0;

            while (n / 10 != 0)
            {
                digits[i] = n % 10;
                n = n / 10;
                i++;
            }

            digits[i] = n % 10;

            return i + 1;
        }

        static int[] Factorial = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };

        static void Main(string[] args)
        {
            var total = -3;
            var arr = new int[10];

            foreach (var number in Enumerable.Range(0, Int32.MaxValue))
            {
                Array.Clear(arr, 0, 10);
                var count = FillDigits(number, arr);

                int sum = 0;
                for (int i = 0; i < count; i++)
                {
                    sum += Factorial[arr[i]];
                }

                if (sum == number)
                {
                    Console.WriteLine(number);
                    total += sum;
                }
            }

            Console.WriteLine("Total: " + total);
            Console.ReadLine();
        }
    }
}
