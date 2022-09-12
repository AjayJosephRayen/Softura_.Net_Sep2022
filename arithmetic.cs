using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maths
{
    
   
    class operators
    {
        
        
        public void add(int n1, int n2)
        {
            
           
            Console.WriteLine("Addition={0}",n1+n2);
        
        }
        public void subtract(int n1, int n2)
        {
            
            
            Console.WriteLine("Subtraction={0}",n1-n2);

        }

    }
    class operation : operators
    {

        public void div(int n1 , int n2)
        {

            Console.WriteLine("Division={0}",n1/n2);
        }
        public void mult(int n1,int n2)
        { 
        Console.WriteLine("Multiplication={0}",n1*n2);
        }
    
    }
    internal class arithmetic
    {
        public static void Main()
        {
            operation obj = new operation();
            obj.add(100,200);
            obj.subtract(200,100);
            obj.div(100,5);
            obj.mult(100,5);

        }

    }
}
