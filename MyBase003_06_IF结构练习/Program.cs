using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase003_06_IF结构练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("请输入你的年龄:");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    if (age>=23)
            //    {
            //        Console.WriteLine("你到结婚年龄了!");
            //    }
            //    Console.ReadKey();

            //Console.WriteLine("请输入老苏的语文成绩:");
            //int chinese=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入老苏的音乐成绩:");
            //int music = Convert.ToInt32(Console.ReadLine());
            //if ((chinese>90 && music>80) || (chinese==100 && music>70))
            //{
            //    Console.WriteLine("奖励100元");
            //}
            //Console.ReadKey();

            Console.WriteLine("请输入用户名:");
            string name=Console.ReadLine();
            Console.WriteLine("请输入密码:");
            string pwd=Console.ReadLine();

            if (name=="admin"&& pwd=="888888")
            {
                Console.WriteLine("登录成功");
            }
            Console.ReadKey();
        }
    }
}
