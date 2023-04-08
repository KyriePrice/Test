using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_12_算术运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n1 = 10;
            //int n2 = 3;
            //int result = n1 / n2;
            //Console.WriteLine(result);
            //Console.ReadKey();

            //int chinese = 95;
            //int math = 85;
            //int english = 67;

            //Console.WriteLine("总成绩是{0},平均成绩是{1}",chinese+math+english,(chinese+math+english)/3);
            //Console.ReadKey();


            //等号2边的数据类型必须一样
            double pi = 3.14;
            int r = 5;
            double area = pi * r * r;
            double perimeter = 2 * pi * r;
            Console.WriteLine("圆面积是{0}周长是{1}",area,perimeter);
            Console.ReadKey();

        }
    }
}
