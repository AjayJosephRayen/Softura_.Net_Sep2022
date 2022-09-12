using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maths
{
    internal class taskabst
    {
        abstract class task1
        {
            public abstract void Membership();
            
        }
        
        class silver : task1
            {
            public override void Membership()
            {
                Console.WriteLine("Silver : \n 3 days accomodation at resort");
            }

}
        class gold : task1
        {
            public override void Membership()
            {
                Console.WriteLine("Gold :\n 5 days accomodation at resort \n &2 dinners on the house ");
            }

        }
        class Platinum : task1
        {
            public override void Membership()
            {
                Console.WriteLine("Platinum :\n 7 days accomodation at resort \n & 5 dinners on the house ");
            }

        }
        public static void Main()
        {
            silver sil = new();
            sil.Membership();
            gold gol = new gold();
            gol.Membership();
            Platinum plat=new Platinum();
            plat.Membership();
        
        
        }
    }
}
