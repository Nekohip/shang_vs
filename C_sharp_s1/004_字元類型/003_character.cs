using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_字元類型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'c';
            int b = a; //a被轉換成int類型，容器小的可賦值給容器大的
            Console.WriteLine(a);
            Console.WriteLine(b);//會輸出字符的ASCII碼

            /*int c = 1;
            char d = b; //int不能轉char，因為int容量比char大
            Console.WriteLine(a);*/
            int c = 97;
            char d = (char)c; //(char)強制類型轉換，照ASCII碼轉換成字元
            Console.WriteLine(d);
            char e = '\n';
            Console.WriteLine(e);
            //Console.WriteLine("c:\a\b\c");
            Console.WriteLine("c:\\a\\b\\c");
            Console.WriteLine(@"c:\a\b\c"); //@取消所有跳脫字元功能，"不會取消，要輸出"要寫""

            string str = @"https://www.bilibili.com/  """"
            video/BV1gR4y1b7oW";    //@後的字串可以換行寫，輸出也會換行
            string str1 = "123" + "456";  //字串相加會合併
            string str2 = str1 + "789";

            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str1 + str2 + "999");
        }
    }
}
