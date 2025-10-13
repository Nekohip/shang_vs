using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ReadLine
{
    internal class Readline
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            Console.WriteLine(str + "-");

            String a = Console.ReadLine(); //readline的屬性是string
            int b = Convert.ToInt32(a); //把a轉換成int類型，只能轉換整數
            Console.WriteLine(b+"+");

            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c+"*");
        }
    }
}
