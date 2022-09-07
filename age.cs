using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electricitybill
{
    internal class age
    {
        public static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Your Age?");
            int age=Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=age; i++)
            {
                Console.WriteLine("{0}",name);
            
            }
        
        }
    }
}
