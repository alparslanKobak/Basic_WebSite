using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MVC01RazorSyntaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
