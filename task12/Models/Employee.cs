namespace EmployeeTsk.Models
{
    public class Employee
    {
       public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public char Gender { get; set; }
        public  Employee getemp()
        {
            Employee employee = new Employee()
            {
                Id = 001,
                Firstname = "Ajay",
                Lastname = "Joseph Rayen",
                Gender = 'M'



            };
            return employee;

        
        }
        public static List<Employee> allemp()
        {
            List<Employee> employees1 = new List<Employee>()
            {
                new Employee() { Id = 1001, Firstname = "Anika", Lastname = "Rhesa Rayen", Gender = 'F' },
                 new Employee() { Id = 1002, Firstname = "Trisha", Lastname = " Rayen", Gender = 'F' },
                  new Employee() { Id = 1003, Firstname = "Murali", Lastname = "Krishna", Gender = 'M' },
                  new Employee() { Id = 1004, Firstname = "Cyril", Lastname = "Poul Rayen", Gender = 'M' },
                  new Employee() { Id = 1005, Firstname = "Lakshmi", Lastname = "Kumari", Gender = 'F' }
            };
            return employees1;
        }
    }
}
