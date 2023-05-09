using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase005_09_类型转换和方法简介
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //失败抛异常
            //int numberOne = Convert.ToInt32("123");   内部调用 int.Parse
            //失败抛异常
            //int number = int.Parse("123abd");
            //Console.WriteLine(number);
            //Console.ReadKey();


            int number = 100;
            bool b= int.TryParse("123as", out number);
            Console.WriteLine(number);
            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}
