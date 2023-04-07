using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_09_接收用户输入
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你的姓名:");
            //string name = Console.ReadLine();
            //Console.WriteLine("你的姓名是{0}.",name);
            //Console.ReadKey();
            Console.WriteLine("你喜欢的水果?");
            string fruit= Console.ReadLine();
            Console.WriteLine("真巧,我也喜欢{0}", fruit);
            Console.ReadKey();
        }
    }
}
