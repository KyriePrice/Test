using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_10_输入练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的姓名,性别,年龄");
            string input=Console.ReadLine();
            Console.WriteLine(input);
            Console.ReadKey();
            Console.WriteLine("请输入你的姓名:");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的性别:");
            string gender = Console.ReadLine();
            Console.WriteLine("请输入你的年龄:");
            string age = Console.ReadLine();
            Console.WriteLine("{0},你的性别是{1},你的年龄是{2}.",name,gender,age);
            Console.ReadKey();
        }
    }
}
