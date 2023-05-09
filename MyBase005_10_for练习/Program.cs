using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase005_10_for练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //bool b = true;
            //for (int i = 0; i < 5; i++)
            //{

            //    Console.WriteLine("请输入第{0}个人的成绩", i + 1);
            //    try
            //    {
            //        int age = Convert.ToInt32(Console.ReadLine());

            //        if (age >= 0 && age <= 100)
            //        {
            //            sum += age;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入的年龄不在正确范围,程序退出");
            //            b = false;
            //            break;
            //        }
            //    }
            //    catch
            //    {

            //        Console.WriteLine("输入的年龄不正确,程序退出");
            //        b = false;
            //        break;
            //    }

            //}
            //if (b)
            //{
            //    Console.WriteLine("5个人的平均年龄是{0}", sum / 5);
            //}

            //Console.ReadKey();



            //string useName = "";
            //string usePwd = "";
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名:");
            //    useName = Console.ReadLine();
            //    Console.WriteLine("请输入密码:");
            //    usePwd = Console.ReadLine();

            //    if (useName != "admin" && usePwd != "888888")
            //    {
            //        Console.WriteLine("用户名,密码错误,请重新登录");
            //    }
            //    else
            //    {
            //        Console.WriteLine("登录成功");
            //        break;
            //    }

            //}
            //Console.ReadKey();


            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                if (sum >= 20)
                {
                    Console.WriteLine("加到{0}的时候,总和大于20",i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
