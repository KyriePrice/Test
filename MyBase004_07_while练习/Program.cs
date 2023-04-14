using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase004_07_while练习
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入学员人数:");
            int persons = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int sum = 0;
            while (i<=persons)
            {
                Console.WriteLine("请输入第{0}个学生的成绩:",i);
                int score = Convert.ToInt32(Console.ReadLine());           //获取成绩
                sum+= score;        //累计成绩
                i++;
            }
            Console.WriteLine("班级为{0}人的班级总成绩是{1},平均成绩是{2}",persons,sum,sum/persons);
            Console.ReadKey();
        }
    }
}
