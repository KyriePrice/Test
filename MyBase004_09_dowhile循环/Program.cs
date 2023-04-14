using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase004_09_dowhile循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("老师,我唱的你满意吗?");
            //string answer=Console.ReadLine();
            //while (answer=="no")
            //{
            //    Console.WriteLine("老师,我再唱一遍,你满意吗?");
            //    answer=Console.ReadLine();
            //}

            //Console.ReadKey();



            //string answer = "";

            //do
            //{
            //    Console.WriteLine("老师,我唱的你满意吗?");
            //    answer= Console.ReadLine(); 
            //} while (answer=="no");

            //Console.WriteLine("OK,放学回家~");
            //Console.ReadKey();


            //string name = "";
            //string pwd = "";

            //do
            //{
            //    Console.WriteLine("请输入用户名:");
            //    name = Console.ReadLine();
            //    Console.WriteLine("请输入密码:");
            //    pwd = Console.ReadLine();
            //} while (name != "admin" || pwd !="888888");

            //Console.WriteLine("登录成功");
            //Console.ReadKey();


            string name = "";
            do
            {
                Console.WriteLine("请输入学员姓名,输入q结束.");
            } while (name!="q");

            Console.ReadKey();
        }
    }
}
