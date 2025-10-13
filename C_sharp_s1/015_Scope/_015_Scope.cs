using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Scope
{
    internal class _015_Scope
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.Write(a);

            //if while for裡的變數只能在局部使用，跳出後會被清空
            /*if (true)
            {
                int a = 10;  //子作用域不能定義父作用域定義過的變數名
                int b = 20;
                Console.Write(b);
                if (true)
                {
                    int c = 30;
                    Console.Write(c);
                }
                Console.Write(c);
            }
            Console.Write(b);*/

            while (true)
            {
                int d = 40;
                Console.WriteLine(d);
            }
            Console.Write(d);

            /* for(int e = 0; e < 10; e++)
             {
                 Console.WriteLine(e);
             }
             Console.Write(e);*/



        }
    }
}
