using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase004_02_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool b=true;  //定义Bool  输出前做判断  保证输出
            ////try catch  之间不能有其他的代码
            //double yearMoney = 5000;
            //Console.WriteLine("请输入李四的年终评级:");
            //string level = Console.ReadLine();

            //if (level=="A")
            //{
            //    yearMoney += 500;
            //}else if (level=="B")
            //{
            //    yearMoney += 200; ;
            //}
            //else if (level == "C")
            //{

            //}
            //else if (level == "D")
            //{
            //    yearMoney -= 200;
            //}
            //else if (level == "E")
            //{
            //    yearMoney -= 500;
            //}
            //else
            //{
            //    Console.WriteLine("输入有误,程序退出");
            //    b = false;
            //}
            //if (b)
            //{
            //    Console.WriteLine("李四明年的工资是{0}", yearMoney);
            //}

            //Console.ReadKey();


            /*
            
            switch(变量或表达式值)
            {
                case  值1:执行代码;
                break;    跳出switch 结构

                case  值2:执行代码;
                break;    跳出switch 结构

                ...
                default: 执行代码;
                break;           
            }

            */
            bool b = true;
            double yearMoney = 5000;
            Console.WriteLine("请输入李四的年终评级:");
            string level = Console.ReadLine();

            switch (level)
            {
                case "A": yearMoney += 500;
                    break;
                case "B": yearMoney += 200;
                    break;
                case "C": break;
                case "D": yearMoney -= 200;
                    break;
                case "E": yearMoney -= 500;
                    break;
                default: Console.WriteLine("输入有误,程序退出");
                    b= false;
                    break;
            }
            if (b)
            {
                Console.WriteLine("李四明年的工资是{0}", yearMoney);
            }
            
            Console.ReadKey();


        }
    }
}
