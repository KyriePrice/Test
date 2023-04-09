using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace MyBase003_03_关系逻辑运算
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool b= 1500 > 1;  //关系表达式的结果是个bool类型   >.<.==.<=.>=.!=  关系运算符    关系表达式由关系运算符连接




            //// 逻辑运算符 &&逻辑与  ||逻辑或  !逻辑非  由逻辑运算符连接的表达式  逻辑表达式 

            //bool b1 = 5 < 3 && true;  //逻辑表达式结果返回bool值
            


            ////复合赋值运算符  += -= *= /= %=  二元表达式
            //int num = 10;
            //num += 20;    // 与num = num + 20;等价
            //Console.WriteLine(num);
            //Console.WriteLine(b1);

            //Console.WriteLine(b);
            //Console.ReadKey();


            Console.WriteLine("请输入老苏的语文成绩:");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入老苏的数学成绩:");
            int math = Convert.ToInt32(Console.ReadLine());

            bool b = chinese >90 && math> 90;  
            bool b1 = chinese > 90 || math > 90;
            Console.WriteLine(b);
            Console.WriteLine(b1);
            Console.ReadKey();  

        }
    }
}
