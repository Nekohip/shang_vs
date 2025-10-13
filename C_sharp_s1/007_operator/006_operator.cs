using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 23 + 23;
            int b = 2 - 10;
            int c = 4 * 23;
            int d = 45 / 10; //會省略小數
            int e = 45 % 10;
            //其中一邊是小數，結果會是小數
            double f = 45 / 10.1;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);*/

            //賦值運算子
            int a = 0;
            a += 10;//10
            Console.WriteLine(a);
            a -= 5;//5
            Console.WriteLine(a);
            a *= 3;//15
            Console.WriteLine(a);
            a /= 6;//2
            Console.WriteLine(a);
            a %= 2;//0
            Console.WriteLine(a);

        }
    }
}
