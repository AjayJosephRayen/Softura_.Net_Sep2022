using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqltask
{
    internal class agename
    {
        public int Age { get; set; }
        public string Name { get; set; }


        public agename()
        {
        }
        public agename(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    public class Member
    {
        public static void Main()
        {
            agename memberInitialize = new agename { Name = "Ajay", Age = 22 };
            agename member = new agename("Ajay", 22);

        }
    }
}
