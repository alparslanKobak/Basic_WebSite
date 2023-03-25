using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MVC06SectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
