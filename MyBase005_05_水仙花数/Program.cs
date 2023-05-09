using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase005_05_水仙花数
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 100; i < 1000; i++)
            {
                int bai = i / 100;
                int shi = i % 100 / 10;
                int ge = i % 10;

                if (bai * bai * bai + shi * shi * shi + ge * ge * ge == i)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}
