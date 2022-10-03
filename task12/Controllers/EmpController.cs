using Microsoft.AspNetCore.Mvc;
using EmployeeTsk.Models;

namespace EmployeeTsk.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult singleemp()
        { 
        Employee emp1=new Employee();
            emp1 = emp1.getemp();
            return View(emp1);
        
        }
        public IActionResult allemployees()
        { 
        List<Employee> emp2=Employee.allemp();
            return View(emp2);
        }
        public IActionResult AddDatas()
        {
            return View();
        }
    }
}
