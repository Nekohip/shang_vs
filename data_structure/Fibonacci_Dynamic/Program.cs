using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Dynamic
{
    internal class Program
    {
        static int[] output = new int[1000];  //fib的暫存區
        static int Fib(int n)
        {
            int result = output[n];
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return (Fib(n - 1) + Fib(n - 2));
        }

        static void Main(string[] args)
        {
        }
    }
}
