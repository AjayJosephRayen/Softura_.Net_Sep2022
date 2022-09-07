using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace electricitybill
{
    internal class TvPackage
    {
        public static void Main()
        {
            Console.WriteLine("Which Package do you Choose?");
            string[] package = { "Package A", "-south Special", "-Children's club", "-Movies" };
            foreach (string name in package)
                Console.WriteLine(name);
            string[] package1 = { "Package B", "-News", "-Sports", "-Movies", "-Regional 2" };
            foreach (string name1 in package1)
                Console.WriteLine(name1);
            string[] package2 = { "Package C", "-Discovery", "-History", "-National" };
            foreach (string name2 in package2)
                Console.WriteLine(name2);
            Console.WriteLine("Choose A or B or C :");
            string channels = Console.ReadLine();
            
            switch (channels)
            {
               
                case "A": Console.WriteLine(" Amount to be paid for Package A is : 250/- ");
                    break;
                case "B":
                    Console.WriteLine(" Amount to be paid for Package B is : 450/- ");
                    break;
                case "C":
                    Console.WriteLine(" Amount to be paid for Package A is : 350/- ");
                    break;
                    default: Console.WriteLine("Choose the Proper option");
                    break;
            }
            
        }
    }
}
