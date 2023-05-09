using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase005_06_乘法口诀表
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", j, i, i * j);
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();


            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", j, i, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
