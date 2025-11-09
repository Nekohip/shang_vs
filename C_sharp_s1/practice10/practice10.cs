using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace practice10
{
    internal class practice10
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            char[] chars = new char[20];
            float[] floats = new float[5];
            string[] strings = new string[8];  //字串預設值是null，其他是0

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int j = 0;
            while(j < numbers.Length)
            {
                Console.WriteLine(numbers[j]);
                j++;
            }
            
        }
    }
}
