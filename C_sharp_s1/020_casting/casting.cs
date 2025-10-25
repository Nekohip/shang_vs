using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_casting
{
    internal class casting
    {
        static void Main(string[] args)
        {
            byte a = 32;
            int b = 1000;

            //b = a;  //隱式轉換
            //Console.Write(b);

            a = (byte)b;  //顯式轉換
            Console.Write(a);

            //字串轉數字
            int c = Convert.ToInt32("123");
            double d = Convert.ToDouble("1.987");

            //數字轉字串
            string e = 123 + "";
            string f = Convert.ToString(123);
        }
    }
}
