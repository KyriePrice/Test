using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase003_08_if_elseif结构
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("请输入学员成绩:");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score>=90 && score <= 100)
            //{
            //    Console.WriteLine("A");
            //}
            //if (score >= 80 && score < 90)
            //{
            //    Console.WriteLine("B");
            //}
            //if (score >= 70 && score < 80)
            //{
            //    Console.WriteLine("C");
            //}
            //if (score >= 60 && score < 70)
            //{
            //    Console.WriteLine("D");
            //}
            //if (score < 60)
            //{
            //    Console.WriteLine("E");
            //}
            //Console.ReadKey();


            //Console.WriteLine("请输入学员成绩:");
            //int score = Convert.ToInt32(Console.ReadLine());

            //if (score >= 90 && score <= 100)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    if (score >= 80)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else
            //    {
            //        if (score >= 70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else
            //        {
            //            if (score >= 60)
            //            {
            //                Console.WriteLine("D");
            //            }
            //            else
            //            {
            //                Console.WriteLine("E");
            //            }

            //        }
            //    }
            //}
            //Console.ReadKey();

            //多条件 区间性判断
            Console.WriteLine("请输入学员成绩:");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }

            Console.ReadKey();
        }
    }
}
