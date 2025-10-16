using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_random
{
    internal class _018_random
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            //隨機生成0-100
            Console.Write(rd.Next(0,100));
        }
    }
}
