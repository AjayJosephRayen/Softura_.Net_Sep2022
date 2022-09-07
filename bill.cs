using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace electricitybill
{
    internal class bill
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Customer Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Units used");
            int unit = Convert.ToInt32(Console.ReadLine());
            int tot;



            if (unit <= 200)
            {
                tot = 2 * unit;
                Console.WriteLine("Amount to be paid is:", +tot);
            }
            else if (unit >= 201 && unit <= 350)

            {

                int slot1 = unit - 200;
                Console.WriteLine("Amount to paid is:{0}", 400 + slot1 * 3);


            }
            else if (unit >= 351 && unit <= 500)
            {
                int slot2 = unit - 350;
                Console.WriteLine("Amount to be paid is:{0}", 850 + slot2 * 5);

            }
            else if (unit < 501)
            {
                int slot3 = unit - 500;
                Console.WriteLine("Amount to be paid is:{0}",1600+slot3*7);
            
            }

        
        
        }
    }
}
