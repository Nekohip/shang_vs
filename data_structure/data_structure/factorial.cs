using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure
{
    internal class factorial
    {
        //階乘
        static int Fac(int n)
        {
            if (n == 0) //遞迴終止條件
                return 1;
            else
                return n * Fac(n - 1);  //遞迴呼叫
           //5*Fac(5-1)=5*4*Fac(4-1)=5*4*3*Fac(3-1)=5*4*3*2*1*Fac(1-1)=5*4*3*2*1*1
        }

        static void Main(string[] args)
        {
            Console.WriteLine("5!="+Fac(2));
            Console.ReadKey();
        }
    }
}
