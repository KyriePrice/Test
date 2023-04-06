using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_03_变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //变量类型 变量名
            //变量名=值
            //100

            int number;  //在内存中开辟一个存储区域
            //给变量赋值
            number= 100; //把100存储到这个区域

            int n = 100;//简写形式
            double d = 3.14;
            string zName = "MiuMiu";
            char gen= 'A';
            decimal money = 500m;

            //红色波浪线   语法错误
            //绿色波浪线   语法没有错误  提示有可能出现错误   警告线
            //先声明 再赋值  后使用
        }
    }
}
