using System;

namespace Vypocet
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Fsum(7,15));//for
            Console.WriteLine(Wsum(7, 15));//while
            Console.WriteLine(DWsum(7, 15));//do-while
            Console.WriteLine(Rsum(7, 15));//rekurze
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
            while (i <= n)
            {
                res += (i % 2 == 1) ? (x * n) / Factorial(i) : -(x * n) / Factorial(i);
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
                res += (i % 2 == 1) ? (x * n) / Factorial(i) : -(x * n) / Factorial(i);
                i++;
            } while (i <= n);
            return res;
        }            
        static int index = 1;
        static int res = 1;
        private static int Rsum(int x, int n)
        {
            if (index == 1)
            {
                res = 1;
            }
            if (index <= n)
            {
                res += (index % 2 == 1) ? (x * n) / Factorial(index) : -(x * n) / Factorial(index);
                index++;
                Rsum(x, n);
            }
            index = 1;

            return res;
        }

        private static int Factorial(int x)
        {
            int res = 1;
            while (x > 1)
            {
                res *= x;
                x -= 1;
            }
            return res;
        }


    }
}
