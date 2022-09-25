using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maths
{
    internal class productjagg
    {

        public static void Main()
        {
            string[] list = new string[] { "A","B","C"};
            string[] productname = new string[] { "Biscuits", "Chocolate", "Drinks"};
            string[][] products = new string[3][];
            products[0] = new string[] { "Oreo", "Bourbon", "Darkfantasy", "hide&seek" };
            products[1] = new string[] { "Diary milk", "Twix", "hershey" };
            products[2] = new string[] { "minutemaid", "fanta","pepsi","applejuice" };
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("product" + i);
                for (int j = 0; j < products[i].Length; j++)
                {

                    Console.Write(products[i][j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
