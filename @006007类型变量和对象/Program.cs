using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _006007类型变量和对象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myType=typeof(Form);  
            PropertyInfo[]pInfos = myType.GetProperties();
            MethodInfo[]mInfos=myType.GetMethods();
            foreach (var p in pInfos)
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine("====================================");

            foreach (var m in mInfos)
            {
                Console.WriteLine(m.Name);
            }

            Type meType = typeof(Form);
            Console.WriteLine(meType.FullName);
            Console.WriteLine(meType.IsClass);
            //Console.WriteLine(myType.BaseType.BaseType.FullName);


            Form f=new Form();
            f.WindowState=FormWindowState.Maximized;
            f.ShowDialog();
        }
    }
}
