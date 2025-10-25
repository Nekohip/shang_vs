using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Integral_numeric_types
{
    internal class types
    {
        static void Main(string[] args)
        {
            /*sbyte a = 100;
            sbyte b = -100;

            int c = 1234567891;  //十億(10位)
            long d = 1234567891234567891;  //百京(19位)

            byte e = 100;
            short f = 12345;  //萬

            a = (sbyte)c;  //大容器放不進小容器，可以強塞
            Console.Write(a);  //太大的數放進太小的容器數字會丟失

            a = e;*/  //無符號不能丟進有符號，相反也是

            float f = 12345678912345678912; //最多千京(20位)，但超過七位數輸出會用科學記號(E+)
            Console.WriteLine(f);
            float g = 1.123456789f;  //加f才是float類型，沒加是double，f可存在double
            float h = 1.6f;
            float i = g + h;  //能存小數點後6位
            Console.WriteLine(i);

            decimal j = 12345678912345678912;  //千京(20位)
            Console.WriteLine(j);



        }
    }
}
