using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Fibonacci
    {
        //費波納契數列
        static long Fib(long n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return (Fib(n - 1) + Fib(n - 2));
            //Fib(4)=(Fib(3)+Fib(2))=(Fib(2)+Fib(1))+(Fib(1)+Fib(0))
            //=(Fib(1)+Fib(0)+1+1+0)=3
        }
        static void Main(string[] args)
        {
            long num;
            string str;

            Console.WriteLine("使用遞迴計算費式級數");
            Console.Write("請輸入一個正整數");
            str = Console.ReadLine();
            num = long.Parse(str);
            if (num < 0)
                Console.WriteLine("輸入的數字必須大於0");
            else
                Console.Write("F(" + num + ")=" + Fib(num) + "\n");
            Console.ReadKey();
        }
    }
}
