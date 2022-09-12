using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maths
{
    
    internal class taskabs2
    {
        abstract class addition
        { 
        public abstract void add(int n1, int n2 );
        }
        abstract class subtraction
        {
            public abstract void sub(int n1, int n2);
        }
        abstract class multiplication
        {
            public abstract void multi(int num1, int num2);
        }
        abstract class division
        {
            public abstract void div(int num1, int num2);
        }
        
        class task1 : addition
        {
            

            public override void add(int n1, int n2)
                
            {
                Console.WriteLine("The sum of {0} and {1} is {2} ", n1,n2,n1+n2);
            }
        }
        class task2 : subtraction
        {
            

            public override void sub(int n1, int n2)
            {
                Console.WriteLine("The sub of {0} and {1} is {2} ", n1, n2, n1 - n2);
            }
        }
        class task3 : multiplication
        {
            

            public override void multi(int num1, int num2)
            {
                Console.WriteLine("The product of {0} and {1} is {2} ", num1, num2, num1 * num2);
            }
        }
        class task4 : division
        {
            

            public override void div(int num1,int num2)
            {
                Console.WriteLine("The division of {0} and {1} is {2} ", num1, num2, num1/num2);
            }
        }
        public static void Main()
        { 
        task1 task = new task1();
            task.add(100,100);
            task2 tas = new task2();
            tas.sub(10,5);
            task3 ta = new task3();
            ta.multi(10,5);
            task4 tak = new task4();
            tak.div(10,5);


        }
    }
}
