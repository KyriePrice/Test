using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase004_08_while循环的练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string answer = "";

            //int i = 0;


            //while (answer!="yes" && i<10)    //不可以用||
            //{

            //    Console.WriteLine("这是我第{0}遍给你讲,你会了吗?yes/no",i+1);
            //    answer= Console.ReadLine();

            //    if (answer=="yes")
            //    {
            //        Console.WriteLine("会了,那就放学!");
            //        break;
            //    }
            //    i++;

            //}

            //Console.ReadKey();






            //double people = 80000;
            //int year = 2006;
            //while (people<200000)
            //{
            //    people *= 1.25;
            //    year++;
            //}
            //Console.WriteLine("到第{0}年的时候人数将达到20W人", year);
            //Console.ReadKey();




            //string answer = "";
            //while (answer!="yes" && answer!="no")
            //{
            //    Console.WriteLine("请重新输入");
            //    answer=Console.ReadLine();
            //}
            //Console.ReadKey();


            //int i = 1;
            //string useName = "";
            //string usePwd = "";
            //while ((useName != "admin" || usePwd != "888888") && i<=3)
            //{
            //    Console.WriteLine("请输入用户名:");
            //    useName= Console.ReadLine();
            //    Console.WriteLine("请输入密码:");
            //    usePwd= Console.ReadLine();
            //    i++;
            //}
            //Console.ReadKey();

            string useNameA = "";
            while (useNameA == "")
            {
                Console.WriteLine("请输入用户名,不能为空:");
                useNameA=Console.ReadLine();
            }

            Console.WriteLine("请输入用户名,不能和A相同,并且不能为空!");
            string useNameB = Console.ReadLine();
            while (useNameB==""||useNameB==useNameA)
            {
                if (useNameB=="")
                {
                    Console.WriteLine("用户名不能为空,请重新输入:");
                    useNameB= Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("用户名不能与A相同,请重新输入:");
                    useNameB= Console.ReadLine();   
                }
            }
            Console.ReadKey();
        }
    }
}
