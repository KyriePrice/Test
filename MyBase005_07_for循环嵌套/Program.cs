using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase005_07_for循环嵌套
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count =1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Hello World!第{0}次循环",count);
                    count++;
                }
            }
            Console.ReadKey();
        }
    }
}
