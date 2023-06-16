using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static long GetGCD(long a, long b)
        {
            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            return a > b ? GetGCD(a % b, b) : GetGCD(a, b % a);
        }

        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }


        static void Main(string[] args)
        {
            int fac = Factorial(10);
            Console.WriteLine(fac);

            int fib = Fibonachi(16);
            Console.WriteLine(fib);

            Console.WriteLine("Введите a и b:");
            Console.Write(" a = ");
            var a = Convert.ToInt64(Console.ReadLine());
            Console.Write(" b = ");
            var b = Convert.ToInt64(Console.ReadLine());

            var gcd = GetGCD(a, b);

            Console.WriteLine($"\nНОД равен {gcd}");

        }
    }
}
