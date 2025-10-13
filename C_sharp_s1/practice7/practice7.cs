using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace practice7
{
    internal class practice7
    {
        static void Main(string[] args)
        {
            //1.輸入整數判斷奇偶
            /*Console.Write("請輸入整數: ");

            int a = Convert.ToInt32(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine(a + "為偶數");
            }
            else
            {
                Console.WriteLine(a + "為奇數");
            }*/


            //2.18-30才能參加活動，年齡是奇數獲得獎品
            /* Console.Write("請輸入年齡: ");
             int age = Convert.ToInt32(Console.ReadLine());
             if(age >= 18 && age <= 30 )
             {
                 if(age % 2 != 0)
                 {
                     Console.WriteLine("中獎");
                 }
                 else
                 {
                     Console.WriteLine("未中獎");
                 }
             }
             else
             {
                 Console.WriteLine("不可參加");
             }*/


            //3.輸入考試成績，評級ABCD
            /* Console.Write("輸入成績:");
            int score = Convert.ToInt32(Console.ReadLine());

             if (score >= 90 && score <= 100)
             {
                 Console.WriteLine("評級為A");
             }
             else if(score >= 70)  //前面的條件不滿足才判斷
             {
                 Console.WriteLine("評級為B");
             }
             else if(score >= 60)
             {
                 Console.WriteLine("評級為C");
             }
             else
             {
                 Console.WriteLine("評級為D");
             }*/


            //4.輸入直角坐標系的座標，判斷位於哪個座標軸、象限或原點上
            /*Console.Write("輸入x:");
            int coox = Convert.ToInt32(Console.ReadLine());
            Console.Write("輸入y:");
            int cooy = Convert.ToInt32(Console.ReadLine());

            if(coox > 0 && cooy > 0)
            {
                Console.WriteLine("座標在第一象限");
            }
            else if (coox < 0 && cooy > 0)
            {
                Console.WriteLine("座標在第二象限");
            }
            else if (coox < 0 && cooy < 0)
            {
                Console.WriteLine("座標在第三象限");
            }
            else if (coox > 0 && cooy < 0)
            {
                Console.WriteLine("座標在第四象限");
            }
            else if (0 == coox && cooy != 0)  //判斷相等時要習慣把值放左邊，這樣少寫一個=會報錯
            {
                Console.WriteLine("座標在Y軸");
            }
            else if (coox != 0 && 0 == cooy)
            {
                Console.WriteLine("座標在X軸");
            }
            else
            {
                Console.WriteLine("座標在原點");
            }*/


            //5.輸入三邊長度判斷能否組成三角形(其中兩個邊大於第三邊)
            /*Console.Write("輸入a邊:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("輸入b邊:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("輸入c邊:");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a+b>c && a+c>b && b+c>a)
            {
                Console.Write("可組成三角形");
            }
            else
            {
                Console.Write("不可組成三角形");
            }*/


            //6.輸入年份判斷是否閏年
            /*Console.Write("輸入年分:");
            int year = Convert.ToInt32(Console.ReadLine());
            if((year%4 == 0 && year%100 !=0) || year%400 == 0)
            {
                Console.WriteLine("是閏年");
            }
            else
            {
                Console.WriteLine("非閏年");
            }*/


            //7.輸入非0整數判斷正負，輸出絕對值
            /*Console.Write("輸入一個非0整數:");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num < 0)
            {
                Console.Write(num + "為負數，絕對值為:"+(0 - num));
            }
            else if(num > 0)
            {
                Console.Write(num + "為正數，絕對值為:" + num);
            }*/


            //8.輸入三個整數，求這三個數最大值得平方
            /*Console.Write("輸入第1個整數:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("輸入第2個整數:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("輸入第3個整數:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if(num3 > max)
            {
                max = num3;
            }
            Console.Write("最大值平方為:" + max * max);*/


            //9.輸入兩個大寫英文字母，比較大小，排序小到大為A-Z
            /*Console.Write("輸入第1個字母:");
            char char1 = Convert.ToChar(Console.ReadLine());
            Console.Write("輸入第2個字母:");
            char char2 = Convert.ToChar(Console.ReadLine());

            if (char1 > char2)
            { 
                Console.Write("{0} > {1}", char1, char2);
            }
            else if (char2 > char1)
            {
                Console.Write("{0} > {1}", char2, char1);
            }*/

            /*10.輸入性別及號碼輸出體測項目。
            男生測長跑1000m;單數測跳遠，雙數測伏地挺身。
            女生800m;單數測跳繩，雙數測仰臥起坐。*/
            /*Console.Write("輸入性別:");
            string sex = Console.ReadLine();
            Console.Write("輸入號碼:");
            int num = Convert.ToInt32(Console.ReadLine());

            if(sex == "男")
            {
                if (num % 2 == 0)
                    Console.Write("測長跑1000m、伏地挺身");  //條件只有一行可省略{}
                if (num % 2 != 0)
                    Console.Write("測長跑1000m、跳遠");
            }
            else if (sex == "女")
            {
                if (num % 2 == 0)
                    Console.Write("測長跑800m、仰臥起坐");
                if (num % 2 != 0)
                    Console.Write("測長跑800m、跳繩");
            }*/


            //11.輸入3個整數，從小到大排序輸出
            Console.Write("輸入第1個數:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("輸入第2個數:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("輸入第3個數:");
            int c = Convert.ToInt32(Console.ReadLine());

            //讓c>b>a
            if(a > b)
            {
                int temp = b;
                b = a;
                a = temp;
            }
            if (b > c)
            {
                int temp = c;
                c = b;
                b = temp;
            }
            if (a > b)
            {
                int temp = b;
                b = a;
                a = temp;
            }

            Console.Write("{0} {1} {2}", a, b, c);


            /*12.輸入一個小數m和0/1k，k==0,輸出m的整數；
            k==1,輸出m四捨五入到小數點後一位*/
            /*Console.Write("輸入小數:");
            float m = float.Parse(Console.ReadLine());
            Console.Write("輸入0/1:");
            int k = Convert.ToInt32(Console.ReadLine());

            if(k == 0)
            {   
                Console.Write((int)m);  //用convert.int32會四捨五入至整數
            }
            else if (k == 1)
            {
                //四捨五入:m+0.05,讓小數點第二位進位,x10,轉int去除小數,/10
                //例如3.1515+0.05=3.2015,x10=32.015,轉int=32,/10=3.2
                double m2 = ((int)((m + 0.05) * 10)) / 10.0;  //除數後加小數能讓被除數轉double
                Console.Write(m2);
            }*/


            //字符從轉換成對應數字
            /*char a = '8';
            Console.Write(a - '0');*/


        }
    }
}
