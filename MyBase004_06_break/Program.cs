using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase004_06_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string useName = "";
            string usePwd = "";

            while (useName != "admin" || usePwd!="888888")
            {
                Console.WriteLine("请输入用户名:");
                useName = Console.ReadLine();
                Console.WriteLine("请输入密码:");
                usePwd = Console.ReadLine();
            }

            Console.WriteLine("登录成功");
            Console.ReadKey();
        }
    }
}
