using HRMS_PORTAL.Models;
using Microsoft.AspNetCore.Mvc;
namespace HRMS_PORTAL.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult AddEmployee()
        {
            return View();
        }
    }
}
