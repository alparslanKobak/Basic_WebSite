using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MVC15ViewComponentUsingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
