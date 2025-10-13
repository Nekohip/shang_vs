using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_advanced_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //變數交換(較快,佔內存)
            int a = 5, b = 10;

            int temp = a;

            a = b;
            b = temp;

            Console.WriteLine("a="+a+",b="+b);
            //不使用第三變數(較慢)
            int c = 6, d = 10;

            c = c + d; //c=16
            d = c - d; //d=16-10=6
            c = c - d; //c=16-6=10

            Console.WriteLine("c=" + c + ",d=" + d);
            //格式化輸出
            int e = 23, f = 45;
            //Console.WriteLine(e + "+" + f + "=" +( e + f)); //不便閱讀
            Console.WriteLine("{0}+{1}={2}", e, f, e + f);
            //e(替代值)帶入{0}(替代標記),f帶入{1},e+f帶入{2}
            Console.WriteLine("{0}+{0}={2}", e, f, e + f);
            //可重複取用


        }
    }
}
