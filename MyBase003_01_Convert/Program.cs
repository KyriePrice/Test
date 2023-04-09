using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase003_01_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //类型如果相兼容的2个变量可以使用自动或强制类型转换
            //如果2个类型不兼容 可以使用Convert转换
            //string s = "1223";
            //string ss = "1223adc";  //无法转换  报异常

            //int n = Convert.ToInt32(s);
            //double d = Convert.ToDouble(s);
            //Console.WriteLine(n);
            //Console.WriteLine(d);
            //Console.ReadKey();


            Console.WriteLine("请输入你的姓名:");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的语文成绩:");
            string strchinese= Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩:");
            string strmath = Console.ReadLine();
            Console.WriteLine("请输入你的英语成绩:");
            string strenglish = Console.ReadLine();
            //Console.ReadLine 存储string

            //int chinese = Convert.ToInt32(strchinese);
            //int math = Convert.ToInt32(strmath);
            //int english = Convert.ToInt32(strenglish);

            double chinese = Convert.ToDouble(strchinese);
            double math = Convert.ToDouble(strmath);
            double english = Convert.ToDouble(strenglish);
            double sumScore = chinese+math+english;
            double avgScore = (int)sumScore*0.1 / 3;  //强制转换成int类型   *0.1后转换成 double

            Console.WriteLine("{0}的总成绩是{1},平均成绩是{2}",name,chinese+math+english,(chinese + math + english) /3 );
            Console.WriteLine("{0}的总成绩是{1},平均成绩是{2}", name, sumScore,avgScore);
            Console.ReadKey();
        }
    }
}
