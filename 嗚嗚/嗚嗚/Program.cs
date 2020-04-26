using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 嗚嗚
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var list = new List<int>() { 1, 2, 3, 4, 5, 6 };//宣告整數集合
            foreach (int b in list)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();
            Console.WriteLine(list[3]);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Max());
            #region 冒泡
            for (int i = 0; i < 4; i++)
            {
                if (i == 2) continue;
                Console.WriteLine(i);
            }
            int s = Array.IndexOf(a, 10);//取出值為10的註標
            Array.Reverse(a);//反轉陣列
            Array.Sort(a);//排序陣列
            Console.WriteLine(s);
            Console.ReadKey();
            #endregion
        }
    }
}
