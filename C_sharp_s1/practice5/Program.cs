using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            bool isYoung;
            Console.Write("輸入年齡:");
            age = Convert.ToInt32(Console.ReadLine());

            isYoung = age >= 18 && age <= 60;
            Console.WriteLine(isYoung);
            
        }
    }
}
