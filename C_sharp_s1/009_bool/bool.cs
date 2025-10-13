using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;  //是的 真的 滿足條件 1
            bool b = false; //不是 假的 不滿足條件 0
            Console.WriteLine(a);
            Console.WriteLine(b);

            //關係運算子(兩邊可以是數字也可以是變數)
            bool c = 45 == 67;
            bool d = 45 < 67;
            bool e = 45 <= 45;
            bool f = 45 > 67;
            bool g = 45 >= 67;
            bool h = 45 != 67;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);

            bool i = a != b;
            Console.WriteLine(i);

        }
    }
}
