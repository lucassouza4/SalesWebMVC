using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department{ Id=1,Name="Eletronics"});
            departments.Add(new Department { Id=2,Name="Fashion"});
            return View(departments);
        }
    }
}
