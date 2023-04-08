using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_13_显示隐式类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Tshirt = 35;
            int trousers = 120;
            int totalMoney = 3 * Tshirt + 2 * trousers;
            Console.WriteLine(totalMoney);

            //等号2边的数据类型必须一样,如果不一致,满足以下条件,会自动转换(隐式转换)
            // int--double
            // 2种类型兼容   int  double 
            // 目标类型大于源类型

            int number = 10;
            double d = number;

            // double--int  强制类型转换(显示类型转换)
            // 2种类型兼容   int  double
            // 源类型大于目标类型    (int)d

            //88折后的价格
            double realMoney = totalMoney * 0.88;
            Console.WriteLine("{0:0.0000000}",realMoney);   // 0占位  :  0.0000000显示格式
            Console.ReadKey();
        }
    }
}
