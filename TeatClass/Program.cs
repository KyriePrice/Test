using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Form myForm;
            //myForm=new Form();//()构造器，初始化方法
            //myForm.Text = "HelloWorld!";
            //myForm.ShowDialog();
            //Form myForm1;
            //Form myForm2;
            //myForm1=new Form();
            //myForm2 = myForm1;
            //myForm1.Text = "MyForm1";
            //myForm2.ShowDialog();
            //var x = 3;
            //Console.WriteLine(x.GetType().FullName);
            //double x;
            //x = 3.0;
            Calculator c = new Calculator();  //new建立一个Calculator实例
            int x= c.Add(2, 3);
            Console.WriteLine(x);
            //string s = c.Today();
            //Console.WriteLine(s);
            c.Today();
        }
    }

    class Calculator
    {
       public int Add(int a,int b)  //方便引用 使用 public
        {
            int result = a + b;
            return result;
        }

        public void Today()
        {
           string str = DateTime.Now.Day.ToString();
            Console.WriteLine(str);
        }
    }
}
