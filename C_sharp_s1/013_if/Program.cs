using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());

            if(age<=16)
            {
                Console.WriteLine("可以進入");
            }
            else
            {
                Console.WriteLine("不可進入");
            }

            Console.WriteLine("程式結束");

        }
    }
}
