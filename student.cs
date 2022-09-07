using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electricitybill
{
    internal class student
    {
        public static void Main()
        {

            Console.WriteLine("Enter your name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter your Maths mark:");
            int m =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Science mark:");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Social Science mark:");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your English mark:");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your French mark:");
            int f = Convert.ToInt32(Console.ReadLine());
            int tot = m + s + o + e + f;
            int avg = tot / 5;
            Console.WriteLine("Total Marks = {0}",tot);
            Console.WriteLine("Percentage obtained = {0}", avg);

        }
    }

}
