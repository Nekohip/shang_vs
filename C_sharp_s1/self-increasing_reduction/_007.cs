using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_self_increasing_reduction
{
    internal class _007
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a++;    //先賦值再自增
            //int b = ++a;    //先自增再賦值
            Console.WriteLine(a+":"+b);
            Console.WriteLine(a++);
            Console.WriteLine(a);

        }
    }
}
