using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice6
{
    internal class practice6
    {
        static void Main(string[] args)
        {
            /*int num = Convert.ToInt32(Console.ReadLine());
            int n1 = num / 100;
            int n2 = num % 100 / 10;
            int n3 = num % 10;

            Console.WriteLine("反轉數字為{0}{1}{2}",n3,n2,n1);*/

            /*int pw = Convert.ToInt32(Console.ReadLine());
            //1"2"3"4"5
            int n10 = pw / 10 % 10;
            int n1000 = pw / 1000 % 10;

            int pwnew = n1000 * 10 + n10;
            char realpw = (char)pwnew;

            Console.WriteLine(realpw);*/

            int score1 = Convert.ToInt32(Console.ReadLine());
            int score2 = Convert.ToInt32(Console.ReadLine());
            bool score_g = score1 >= 90 && score2 >= 90;

            Console.WriteLine(score_g);



        }
    }
}
