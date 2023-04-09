using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase003_02_加加减减
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字:");
            int number=Convert.ToInt32(Console.ReadLine());

            int result = 10 + number++;   //+在后  先加原值
            int result1 = 10 + ++number;  //+在前  先自加

            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(a);
            Console.WriteLine(b);   
            Console.ReadKey();
        }
    }
}
