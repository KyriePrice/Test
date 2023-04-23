using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase005_04_for循环练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i >0; i--) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //int sum = 0;

            //for (int i = 1; i <=100 ; i++)
            //{
            //    sum+= i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            int sum = 0;
            for (int i = 0; i <= 100; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();





        }
    }
}
