using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
