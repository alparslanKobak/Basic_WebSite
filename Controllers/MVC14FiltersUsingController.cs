using Microsoft.AspNetCore.Mvc;
using WebApplication1.Filters;

namespace WebApplication1.Controllers
{
    public class MVC14FiltersUsingController : Controller
    {

        [UserControl] // Kendi yazdığımız UserControl attribute ü ile bu action a oturum açmayan kullanıcıların erişimini engelliyoruz.
        public IActionResult Index()
        {
            ViewBag.Kullanici = HttpContext.Session.GetString("UserGuid"); // UserGuid isimli sessiondaki değeri yakala ve ViewBag.Kullanici ile ekrana gönder.
            return View();
        }
    }
}
