using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
