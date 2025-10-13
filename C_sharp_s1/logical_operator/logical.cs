using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_operator
{
    internal class logical
    {
        static void Main(string[] args)
        {
            //&&和(兩邊皆True) ||或(其中一邊true) !非(反轉結果)
            bool a = (3 > 4) && (9 < 6); //False
            bool b = (3 > 2) || (9 < 7); //True
            bool c = !(4 < 7); //False
            bool d = false && false;
            bool e = 1>2 == 2<3 == 3<2;
            //F == T == F，1.F==T >> F，2.F==F >> T

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

        }
    }
}
