using G4.NetITIMVCDay02.Models;
using Microsoft.AspNetCore.Mvc;

namespace G4.NetITIMVCDay02.Controllers
{
    public class EmployeeController : Controller
    {
        /*----------------------------------------------------------------------------------*/
        List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Ramy", Age = 22, Salary = 1234 },
                new Employee { Id = 2, Name = "Mai", Age = 32, Salary = 2234 },
                new Employee { Id = 3, Name = "Ali", Age = 42, Salary = 3234 },
                new Employee { Id = 4, Name = "Omar", Age = 52, Salary = 4234 },
                new Employee { Id = 5, Name = "Mostafa", Age = 28, Salary = 5234 },
                new Employee { Id = 6, Name = "Ahmed", Age = 38, Salary = 6234 },
                new Employee { Id = 7, Name = "Sara", Age = 48, Salary = 7234 },
                new Employee { Id = 8, Name = "Osama", Age = 26, Salary = 8234 },
                new Employee { Id = 9, Name = "Mohamed", Age = 36, Salary = 9234 },
                new Employee { Id = 10, Name = "Nour", Age = 46, Salary = 10234 },
            };
        /*----------------------------------------------------------------------------------*/
        // Action
        // Route => http://localhost:5058/Employee/getall
        public IActionResult GetAll()
        {
            // To Send Data From Controller To View
            ViewBag.Message = "All Employees";
            ViewBag.EmpList = employees;
            return View();
        }
        /*----------------------------------------------------------------------------------*/
        public IActionResult ViewDetails(int id)
        {
            var singleEmp = employees.FirstOrDefault(emp => emp.Id == id);
            ViewBag.emp = singleEmp;
            return View();
        }
        /*----------------------------------------------------------------------------------*/
    }
}
