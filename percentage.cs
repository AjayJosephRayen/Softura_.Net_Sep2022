using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace maths
{
    class gst1
    {
        public void calculatetax(double n1)
        {

            Console.WriteLine("The GST for this amount is :{0}", (n1*12)/100);
        }
    
    }
    class vat1 :  gst1
    {

        public new void calculatetax(double n1) 

        {
            Console.WriteLine("The VAT for this amount is :{0}",n1*1.2);
        
        }
    
    }
    internal class percentage:vat1
    {
        public static void Main()
        {
            gst1 sc = new gst1();
            sc.calculatetax(1000);
            percentage src = new percentage();
            src.calculatetax(1000);
            
        
        }
    }
}
