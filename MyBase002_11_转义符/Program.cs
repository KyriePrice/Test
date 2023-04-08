using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_11_转义符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   \n 换行
            Console.WriteLine("今天天气好晴朗\n处处好春光");
            Console.ReadKey();
            //   \"\" 双引号
            Console.WriteLine("我想在这句话中输出以一个\"\"英文半角的双引号");
            Console.ReadKey();

            //    \t 制表符
            //    \b 退格键
            //    \r\n 换行符 
            //    @ 取消
            string name1 = "张三";
            string name2 = "洋名子司机";
            string name3 = "日本名字";
            string name4 = "棒子专用名字";
            Console.WriteLine("{0}\t\t{1}",name1,name2);
            Console.WriteLine("{0}\t{1}",name3,name4);
            Console.ReadKey();

            Console.WriteLine("我想在这句话中输出以一个\"\"英文半角的双引号");
            Console.WriteLine(@"我想在这句话中输出以一个""英文半角的双引号");
            Console.ReadKey();
        }
    }
}
