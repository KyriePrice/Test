using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase004_05_While循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int times = 0;
            //while (times<10)  //循环条件
            //{
            //    Console.WriteLine("下次考试一定细心!{0}",times);  //循环体
            //    times++;
            //}

            //Console.ReadKey();

            int i = 1;
            int sum = 0;
            while (i<=100)
            {
                if (i%2==0)
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine("100内所有偶数的和是{0}", sum);

            Console.ReadKey();
        }
    }
}
