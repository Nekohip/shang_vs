using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 1;
            while(i <= 10) //會一直判斷條件並執行，直到不滿足
            {
                Console.WriteLine(i);
                i++;
            }
            //不滿足後會跳出，執行後面的程式
            Console.Write("While後");*/

            /* while (true) //寫true是死循環
             {
                 Console.Write("010");
             }*/


            //輸出1-1000
            /*int i = 1;
            while (i <= 1000) 
            {
                Console.WriteLine(i);
                i++;
            }*/
            //條件表達式也是布林表達式，要回傳一個布林值


            //角色血量大於0時，敵人會一直攻擊角色
            /*int charHealth = 100;
            int damage = 11;
            while(charHealth > 0)
            {

                if (charHealth - damage < 0)
                {
                    charHealth = charHealth - damage;
                    Console.WriteLine("敵人攻擊你，血量-" + damage + "，現在血量:0\n新細明體");
                }
                else
                {
                    charHealth = charHealth - damage;
                    Console.WriteLine("敵人攻擊你，血量-" + damage + "，現在血量:" + charHealth);
                }
                    
            }*/


            //輸出1-100和100-1
            /*int i = 0;
            while (i < 100)
            {
                i++;
                Console.WriteLine(i);
            }

            int i2 = 101;
            while (i2 > 1)
            {
                i2--;
                Console.WriteLine(i2);
            }*/


            //輸入整數n，計算1+2+3+...+n
            /*Console.Write("請輸入n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 1 ;
            int i = 1;

            while (i < n)
            {
                i++;
                num += i;
            }

            Console.Write(num);*/

            /*Console.Write("請輸入n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            int i = 1;

            while (i <= n)
            {
                num += i;
                i++;
            }

            Console.Write(num);*/

            //輸出1-100間的所有偶數
            /*int num = 0;
            while(num < 101)
            {
                num++;
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
            }*/

            //輸入兩個整數n1,n2，顯示它們之間(包含n1n2)所有偶數
            /*Console.Write("請輸入n1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入n2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            while (n1 <= n2)
            {
                if (n1 % 2 == 0)
                {
                    Console.WriteLine(n1);
                }
                n1++;
            }*/


            //對一個大於1的自然數n，若n是奇數，執行3n+1，否則n/2，不斷重複，
            //最後n一定會變成1，輸入n，輸出變換的次數
            /* int i = 0;
             Console.Write("請輸入n: ");
             int n = Convert.ToInt32(Console.ReadLine());

             while (n != 1)
             {
                 if (n % 2 != 0)
                 {
                     Console.Write(n + "*3+1=");
                     n = 3 * n + 1;
                     Console.WriteLine(n);
                 }
                 else
                 {
                     Console.Write(n + "/2=");
                     n /= 2;
                     Console.WriteLine(n);
                 }

                 i++;
             }
             Console.Write("變換了" + i + "次");*/


            //2006年培育學生80000人，每年人數增長25%，哪年能達到20萬人?
            /*int stCount = 80000;
            int year = 2006;

            while (stCount < 200000)
            {
                stCount += (int)(stCount * 0.25);
                year++;
            }

            Console.Write(year + "年人數到達" + stCount);*/


            //輸入學生的個數，輸入每個學生的年齡，並計算輸出平均年齡，保留小數點後兩位
            /*Console.Write("請輸入學生個數:");
            int st_count = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            double st_year_sum = 0;

            while (i <= st_count)   
            {
                    Console.Write("請輸入學生" + i + "的年齡:");
                    double st_year = Convert.ToInt32(Console.ReadLine());   //在迴圈中的變數出了迴圈會被回收
                    st_year_sum += st_year;

                    i++;
            }
            double st_avg = Convert.ToDouble(st_year_sum / st_count);
            st_avg = ((int)(st_avg * 100))/100.0;

            Console.Write("學生年齡平均=" + st_avg);*/


            //輸入整數n，輸出1-n每個數，空格隔開
            /*Console.Write("請輸入整數n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i<=n)
            {
                Console.Write(i+" ");
                i++;
            }*/

        }
    }
}
