using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase003_05_分支结构
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你跪键盘的时间:");
            int times = Convert.ToInt32(Console.ReadLine());
            // bool b = times > 60;
            if (times>60)  //判断条件为true时  可以省略true    如果是false  则不能省略  b==false 
            {
                Console.WriteLine("不要做晚饭了");
            }

            Console.ReadKey();

        }
    }
}
