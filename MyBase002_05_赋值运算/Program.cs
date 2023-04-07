using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_05_赋值运算
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //等号连接的表达式成为赋值表达式
            //左边的变量的值,就是赋值表达式的值
            int number = 10;
            number = 50;  //再赋值


            // +号  连接  和  相加作用
            string name = "李四";
            Console.WriteLine("你好"+name);
            Console.WriteLine(number);
            Console.ReadKey();



        }
    }
}
