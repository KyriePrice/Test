using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase004_01_异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //语法没有错误,但在程序运行中,由于某些原因,程序不能运行  try  catch

            //Console.WriteLine("请输入一个数字:");
            //int number = 0;

            //try
            //{
            //    number = Convert.ToInt32(Console.ReadLine());    //输入正确
            //    Console.WriteLine(number * 2);                  //输出            
            //}
            //catch 
            //{
            //    Console.WriteLine("输入数字格式不对,请重新输入!");  //输入错误,输出提示
            //   // number = Convert.ToInt32(Console.ReadLine());
            //}


            //变量的作用域   变量能够使用的范围   在声明的{}括号内
            //Console.ReadKey();
            int number = 0;
            bool b = true;
            Console.WriteLine("请输入一个数字:");
         

            try
            {
                number = Convert.ToInt32(Console.ReadLine());    //输入正确      
            }
            catch
            {
                Console.WriteLine("输入数字格式不对,请重新输入!");  //输入错误,输出提示
                b = false;                                       // number = Convert.ToInt32(Console.ReadLine());
            }

            if (b)
            {
                Console.WriteLine(number * 2);
            }

            //变量的作用域   变量能够使用的范围   在声明的{}括号内
            Console.ReadKey();



        }
    }
}
