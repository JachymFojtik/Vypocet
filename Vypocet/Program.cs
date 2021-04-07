using System;

namespace Vypocet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fsum(5,3));//for
            Console.WriteLine(Wsum(8,4));//while
            Console.WriteLine(DWsum(7,14));//do-while
            Console.ReadKey();
        }
        private static int Fsum(int x, int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res += (i % 2 == 1) ? (x * n) / Factorial(i) : -(x * n) / Factorial(i);
            }
            return res;
        }        
        private static int Wsum(int x, int n)
        {
            int res = 1;
            int i = 1;
            while (i > n)
            {
                res += (i % 2 == 0) ? (x * n) / Factorial(i) : -(x * n) / Factorial(i);
                i++;
            }
            return res;
        }
        private static int DWsum(int x, int n)
        {
            int res = 1;
            int i = 1;
            do
            {
                res += (i % 2 == 0) ? (x * n) / Factorial(i) : -(x * n) / Factorial(i);
                i++;
            } while (i > n);
            return res;
        }

        private static int Factorial(int x)
        {
            int res = 1;
            while (x != 1)
            {
                res *= x;
                x -= 1;
            }
            return res;
        }


    }
}
