using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_04_变量命名规范
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //必须字母,_,@开头,不要以数字开头
            double d = 36.6;//无意义
            int number = 100;
            //不要与C# 关键字冲突
            //C# 严格区分大小写
            //同一个变量名不允许重复定义

            //命名规范 
            //Camel  变量名首字母大写 其余首字母大写  多用于变量
            //Pascal  每个单词首字母大写,其余小写 多用于类,方法

            Console.WriteLine(d);
            Console.ReadKey();


        }
    }
}
