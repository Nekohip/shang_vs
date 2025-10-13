using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    internal class practice3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入第一個整數a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入第二個整數b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write(a+"和"+b+"的平均=");
            Console.WriteLine((a + b)/2);

            Console.WriteLine("請輸入欲分配金額c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入欲分配人數d");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write(c+"元分配給"+d+"個人，每人能拿到");
            Console.Write(c/d+"元");


        }
    }
}
