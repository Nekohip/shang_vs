using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 1; i <= 10; i++) //初始化;條件判斷;增量表達式，不滿足條件跳出
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 11; i++) //條件和上面一樣，但更快，因為只要判斷小於
            {
                Console.WriteLine(i);
            }*/

            /*for (int i = 0; i < 20; i++) //條件和上面一樣，但更快，因為只要判斷小於
            {
                Console.Write("*");
            }*/


            //計算1-100的和
            /*int num = 0;
            for (int i = 1; i < 101; i++)
            {
                num += i;
            }
            Console.Write(num);*/


            //輸出1-100間所有偶數
            /*for (int i = 1; i < 101; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/


            //輸入n和m，計算n-m(含n,m)所有能被17整除的數的和
            /*Console.Write("請輸入n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入m:");
            int m = Convert.ToInt32(Console.ReadLine());
            int num = 0;

            for(; n < m + 1; n++) //可不寫參數(寫在外面)，初始化和增量都不寫就等於while迴圈
            {
                if(n % 17 == 0)
                {
                    num += n;
                }
            }
            Console.Write(num);*/


            //輸入n和m，計算n-m(含n,m)所有奇數及偶數，各一行，數字之間空格
            /*Console.Write("請輸入n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入m:");
            int m = Convert.ToInt32(Console.ReadLine());

            string num1 = "";
            string num2 = "";

            for (; n < m + 1; n++)
            {
                if (n % 2 != 0)
                {
                    num1 += n + " ";
                }
                else
                {
                    num2 += n + " ";
                }
            }
            Console.WriteLine("奇數:" + num1);
            Console.WriteLine("偶數:" + num2);*/
            int i = 1;
            for (; ; )  //參數全不寫就是死循環(一定要分號)
            {
                Console.WriteLine(i);
                i++;

                if (i > 10)
                {
                    break;  //跳出離它最近的迴圈
                }
            }



        }
    }
}
