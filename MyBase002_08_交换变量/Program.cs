using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_08_交换变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "张三";
            //char gender = '男';
            //int age = 18;
            //string tel = "13114115151";
            //Console.WriteLine("我叫{0},我今年{1},我是{2}生,我的电话是{3}",name,age,gender,tel);
            //Console.ReadKey();
            

            int n1 = 10;
            int n2 = 20;
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;
            n1 = n1 - n2;
            n2 = n2 + n1;
            n1 = n2 - n1;
            Console.WriteLine("交换后,n1的值是{0},n2是值是{1}",n1,n2);
            Console.ReadKey();
        }
    }
}
