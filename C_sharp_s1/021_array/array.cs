using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_array
{
    internal class array
    {
        static void Main(string[] args)
        {
            //聲明空陣列
            //int[] ages1;

            //聲明並賦值，這種方式聲明和賦值要在同一行
            int[] ages2 = { 34, 12, 56, 76, 2, 3, 12, 13, 15, 20 };

            //不能這樣寫
            /*int[] ages2;
            ages2 = { 34, 12, 56 };*/

            //即使沒有指定長度，陣列長度聲明後就固定了，也不能往後加元素
            /*ages2[10] = 22;
            Console.WriteLine(ages2[10]);*/
            
            //指定元素 >> 陣列名[索引]
            //Console.WriteLine(ages2[0]);

            int[] ages3;
            //創建一個長度10、元素都是0的陣列，並賦值給ages3
            //ages3 = new int[10];
            //Console.WriteLine(ages3[0]);

            //正常創建方式，ages2的方式是縮寫
            //[]中不寫大小，系統會從{}裡的個數判斷
            //ages3 = new int[] { 1, 2, 3, 4 };

            //大小是從1開始算的，數量和設定的一定要一樣
            ages3 = new int[5] { 1, 2, 3, 4, 5 };

            //修改元素
            ages3[4] = 6;
            //Console.WriteLine(ages3[4]);

            //設定長度的陣列元素個數滿了之後，不能在後面加元素(執行時會報錯)
            ages3[6] = 7;
            //Console.WriteLine(ages3[6]);
        }
    
    }
}
