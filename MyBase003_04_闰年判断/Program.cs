using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase003_04_闰年判断
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要判断的年份:");
            int years = Convert.ToInt32(Console.ReadLine());

            //逻辑与优先级高于逻辑或
            bool b =  years % 400 == 0 || (years % 4 == 0 && years % 100 != 0);

            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
