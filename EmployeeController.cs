using Microsoft.AspNetCore.Mvc;
using MVC2.Models;

namespace MVC2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Emp()
        {
            return "Emplyoee Credentials";
        }
        public IActionResult Employeedetails()
        {
            empdetails details = new empdetails()
            { Id = 100, Name = "Ajay", Department = "EEE" };
            return View("empinfo", details);
        
        }
    }
}
