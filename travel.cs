using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electricitybill
{
    internal class travel
    {
        public static void Main()
        {
            Console.WriteLine("Do You Have Travel History?");
            string name = Console.ReadLine();
            if (name == "Yes" || name == "yes" || name == "YES")
            {
                Console.WriteLine("Do you have temperature?");
                string temp = Console.ReadLine();


                if (temp == "Yes" || temp == "yes" || temp == "YES")
                {
                    Console.WriteLine("Do you have Cough/Fever");
                    string fev = Console.ReadLine();
                    if (fev == "yes" || fev == "YES" || fev == "Yes")
                    {

                        Console.WriteLine("Need to take Swab test");
                    }
                    else
                    {

                        Console.WriteLine("Quarentine Fever Medicine");
                    }

                }
                else {

                    Console.WriteLine("Home Quarentine for 28 days");

                }


            }
            else
            {
                Console.WriteLine("Safe not COVID-19");

            }
        
        }
    }
}
