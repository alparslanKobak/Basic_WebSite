using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
        [Area("Admin")] // Bu controller'ın admin areasında çalışmasını sağladık.
        public IActionResult Index()
        {
            return View();
        }
    }
}
