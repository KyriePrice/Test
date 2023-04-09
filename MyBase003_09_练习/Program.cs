using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase003_09_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入数字1:");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入数字2:");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入数字3:");
            //int numberThree = Convert.ToInt32(Console.ReadLine());

            //if (numberOne>numberTwo && numberOne>numberThree)
            //{
            //    Console.WriteLine(numberOne);
            //}
            //else if (numberTwo > numberOne && numberTwo > numberThree)
            //{
            //    Console.WriteLine(numberTwo);
            //}
            //else
            //{
            //    Console.WriteLine(numberThree);
            //}
            //Console.ReadKey();
            //Console.WriteLine("请输入数字1:");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入数字2:");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入数字3:");
            //int numberThree = Convert.ToInt32(Console.ReadLine());

            //if (numberOne > numberTwo)
            //{
            //    if (numberOne > numberThree)
            //    {
            //        Console.WriteLine(numberOne);
            //    }
            //    else 
            //    {
            //        Console.WriteLine(numberThree);
            //    }
            //}
            //else
            //{
            //    if (numberTwo > numberThree)
            //    {
            //        Console.WriteLine(numberTwo);
            //    }
            //    else
            //    {
            //        Console.WriteLine(numberThree);
            //    }
            //}
            //Console.ReadKey();


            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();
            //if (pwd=="888888")
            //{
            //    Console.WriteLine("登录成功");
            //}
            //else
            //{
            //    Console.WriteLine("密码错误,重新输入");
            //    pwd = Console.ReadLine();
            //    if (pwd=="888888")
            //    {
            //        Console.WriteLine("输入2次,终于成功");
            //    }
            //    else
            //    {
            //        Console.WriteLine("2次输入均错误,程序退出");
            //    }
            //}
            //Console.ReadKey();


            //Console.WriteLine("请输入用户名:");
            //string  name=Console.ReadLine();
            //Console.WriteLine("请输入密码:");
            //string pwd=Console.ReadLine();

            //if (name=="admin" && pwd=="888888")
            //{
            //    Console.WriteLine("登录成功");
            //}
            //else if (name=="admin")
            //{
            //    Console.WriteLine("密码错误,程序退出");
            //}
            //else if (pwd=="888888")
            //{
            //    Console.WriteLine("用户名错误,程序退出");
            //}
            //else
            //{
            //    Console.WriteLine("用户名和密码都错误,程序退出");
            //}
            //Console.ReadKey();



            Console.WriteLine("请输入你的年龄:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age>=18)
            {
                Console.WriteLine("可以查看");
            }
            else if (age<10)
            {
                Console.WriteLine("不可以看");
            }
            else
            {
                Console.WriteLine("可以考虑,请输入Y/N确认");
                string input = Console.ReadLine();
                if (input=="Y")
                {
                    Console.WriteLine("你确认继续");
                }
                else
                {
                    Console.WriteLine("你确认退出");
                }
            }
            Console.ReadKey();
        }
    }
}
