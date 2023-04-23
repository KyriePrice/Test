using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase005_01_复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = "";
            //while (input != "q")
            //{
            //    Console.WriteLine("请输入一个数字,我们将打印该数字的2倍:");
            //    input = Console.ReadLine();
            //    if (input != "q")
            //    {
            //        try
            //        {
            //            int number = Convert.ToInt32(input);
            //            Console.WriteLine("你输入的数字2倍是{0}", number * 2);
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入的字符串不能转换成数字,请重新输入:");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("你输入q,退出程序");
            //    }
            //}
            //Console.ReadKey();


            string input = "";
            int max = 0;
            while (input != "end")
            {
                Console.WriteLine("请输入一个数字,输入end我们将显示你输入的最大值:");
                input = Console.ReadLine();
                if (input != "end")
                {
                    try
                    {
                        int number = Convert.ToInt32(input);
                        if (number > max)
                        {
                            max = number;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("输入的字符串不能转换成数字,请重新输入:");
                    }
                }
                else
                {
                    Console.WriteLine("你刚才输入的数字中的最大值是{0}", max);
                }
            }
        }
    }
}
