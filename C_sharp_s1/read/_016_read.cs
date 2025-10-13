using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read
{
    internal class _016_read
    {
        static void Main(string[] args)
        {
            char a = (char)Console.Read(); //讀取一個字元，轉換成ASCII碼，類型是int
            char b = (char)Console.Read();
            char c = (char)Console.Read();
            //若在第一個read輸入兩個以上字元，字元會進入緩衝區，第二個read會讀取緩衝區中的第二個字元，以此類推。
            //也會讀取到換行(enter)，所以在第一個read按enter會直接結束。
            Console.WriteLine("--------");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
