using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_switch
{
    internal class Switch_
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("要買什麼飲料?");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)    //判斷()裡的變數是以下哪個case
            {
                case 1:
                    Console.Write("礦泉水");
                    break;  //每個case都一定要帶break
                case 2:
                    Console.Write("紅茶");
                    break;
                case 3:
                    Console.Write("綠茶");
                    break;
                case 4:
                    Console.Write("雪碧");
                    break;
                case 5:
                    Console.Write("可口可樂");
                    break;
                case 6:
                    Console.Write("脈動");
                    break;
                default:    //前面條件全不滿足
                    Console.Write("ㄐㄐ");
                    break;
            }*/


            //輸入星期幾，輸出今天要上的課
            Console.Write("請輸入查詢星期:");
            int day = Convert.ToInt32(Console.ReadLine());

            switch(day)
            {
                case 1:
                case 2: //1或2都執行同樣的程式
                    Console.WriteLine("Arduino");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("C++");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("Scratch");
                    break;

                default:
                    Console.WriteLine("輸入錯誤");
                    break;

            }
            //if適合做範圍判斷，switch適合做多條件是否與輸入資料相等的判斷


        }
    }
}
