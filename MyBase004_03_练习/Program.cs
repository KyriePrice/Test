using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase004_03_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入一个姓名,我们会显示他前身的职业:");
            //string name=Console.ReadLine();

            //switch (name)
            //{
            //    case "老杨": Console.WriteLine("开烟馆");
            //        break;
            //    case "老苏": Console.WriteLine("鸭头");
            //        break;
            //    case "老马": Console.WriteLine("头牌");
            //        break;
            //    case "老蒋": Console.WriteLine("皮条");
            //        break;
            //    case "老赵": Console.WriteLine("病猫");
            //        break;



            //    default:
            //        Console.WriteLine("查无此人,估计石头蹦出来的!");
            //        break;
            //}
            //Console.ReadKey();


            Console.WriteLine("请输入一个考试成绩:");
            int score = Convert.ToInt32(Console.ReadLine());

            switch (score / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("B");
                    break;
                case 8:
                    Console.WriteLine("C");
                    break;
                case 7:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("E");
                    break;
            }
            Console.ReadKey();
        }
    }
}
