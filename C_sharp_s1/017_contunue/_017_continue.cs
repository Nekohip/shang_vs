using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_contunue
{
    internal class _017_continue
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    continue;   //中止當前迴圈，繼續下個迴圈
                }
                Console.WriteLine(i);
            }
        }
    }
}
