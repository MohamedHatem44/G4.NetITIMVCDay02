using G4.NetITIMVCDay02.Models;
using Microsoft.AspNetCore.Mvc;

namespace G4.NetITIMVCDay02.Controllers
{
    public class DepartmentController : Controller
    {
        /*----------------------------------------------------------------------------------*/
        List<Department> departments = new List<Department>()
            {
                new Department { Id = 1, Name = "HR" },
                new Department { Id = 2, Name = "PR" },
                new Department { Id = 3, Name = "Social Media" },
                new Department { Id = 4, Name = "Finance" },
            };
        /*----------------------------------------------------------------------------------*/
        public IActionResult GetAll()
        {
            // View Model To Pass Data From Controller To View
            return View(departments);
        }
        /*----------------------------------------------------------------------------------*/
        public IActionResult ViewDetails(int id)
        {
            var dept = departments.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
        /*----------------------------------------------------------------------------------*/
    }
}
