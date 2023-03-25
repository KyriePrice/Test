using System;   //引用System名称空间--方便调用Console类  WriteLine方法
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  //引用Form类库


namespace _001_初识类和名称空间   //_001_初识类和名称空间名称空间
{
    internal class Program  //Program  类名
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Hello World!");  //Console类  WriteLine方法
            Form form=new Form(); //new新建实例  存放变量form
            form.Text = "SMZ";
            form.ShowDialog();
            var x = 3;
            Console.WriteLine(x.GetType().Name);
        }
    }
}
