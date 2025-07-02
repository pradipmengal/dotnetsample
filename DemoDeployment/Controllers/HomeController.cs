using Microsoft.AspNetCore.Mvc;

namespace DemoDeployment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello from IIS deployment project!";
            return View();
        }
    }
}