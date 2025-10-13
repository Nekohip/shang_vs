using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice4
{
    internal class practice4
    {
        static void Main(string[] args)
        {
            /* int num_input = 78;
             int num_10 = num_input / 10;
             int num_1 = num_input % 10;

             Console.WriteLine("十位是{0},個位是{1}",num_10,num_1);*/

            /*int num_input = 996;
            int num_100 = num_input / 100;
            int num_10 = num_input % 100 / 10;
            int num_1 = num_input % 100 % 10;

            Console.WriteLine("百位是{0},十位是{1},個位是{2}",num_100 , num_10, num_1);*/

            int num_input = 5678;
            int num_1000 = num_input / 1000;
            int num_100 = num_input % 1000 /100;
            int num_10 = num_input % 100 / 10;
            int num_1 = num_input % 1000 % 10;
            Console.WriteLine("千位是{0},百位是{1},十位是{2},個位是{3}", num_1000, num_100, num_10, num_1);



        }
    }
}
