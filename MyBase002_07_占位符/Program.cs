using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_07_占位符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //异常  语法没有错误,只是程序运行时,某些原因出问题
            //输出时 按占位顺序输出
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;
            Console.WriteLine("第一个数字是{0},第二个数字是{1},第三个数字是{2}",n3,n2,n1);
            Console.ReadKey();
            string name = "Okey";
            int age = 18;
            string email = "Email@qq.com";
            string address = "Test";
            decimal salary = 5000m;
            Console.WriteLine("我叫" + name + "我住在" + address + "我今年" + age + "岁了" + "我的邮箱是" + email + "我的工资是" + salary);
            Console.WriteLine("我叫{0},我住在{1},我今年{2}岁了,我的邮箱是{3},我的工资是{4}",name,address,age,email,salary);
            Console.ReadKey();
        }
    }
}
