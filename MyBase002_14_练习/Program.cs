using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase002_14_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int days = 46;
            //int weeks = days / 7;
            //int day = days % 7;
            //Console.WriteLine("{0}天是{1}周零{2}天",days,weeks,day);
            //Console.ReadKey();

            int seconds = 107653;
            int days = seconds / 86400;
            int secs = seconds % 86400;
            int hours = secs / 3600;
            secs= secs % 3600;
            int mins = secs % 60;
            secs = secs % 60;
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分{4}秒",seconds,days,hours,mins,secs);
            Console.ReadKey();
        }
    }
}
