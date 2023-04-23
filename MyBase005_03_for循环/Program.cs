using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase005_03_for循环
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int i = 0;
            //while (i<10)
            //{
            //    Console.WriteLine("欢迎光临{0}!",i+1);
            //    i++;
            //}
            //Console.ReadKey();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("欢迎光临{0}!", i + 1);
            }
            Console.ReadKey();
        }
    }
}
