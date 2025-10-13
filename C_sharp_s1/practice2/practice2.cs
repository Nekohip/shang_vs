using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    internal class practice2
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 8;
            Console.WriteLine(a+"+"+b);//輸出3+8
            Console.WriteLine("a+b"+a+b);//字串後+會將+後的數字合併至字串，輸出a+b38
            Console.WriteLine("a+b" + (a + b));//有括號會先運算再合併，輸出a+b11
        }
    }
}
