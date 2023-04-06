using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_01_注释符
{
    internal class Program
    {
        /// <summary>
        /// 文档注释 一般注释类或函数   摘要
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //输出HelloWorld -- 解释作用
            Console.WriteLine("Hello World!");

            //Console.WriteLine("Test!");   注销当前代码 -- 注销作用
            //暂停当前程序

            Console.ReadKey();

            //   当行注释
            /* 多行注释 */

        }
    }
}
