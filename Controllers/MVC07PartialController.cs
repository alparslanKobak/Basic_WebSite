using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MVC07PartialController : Controller
    {
        public IActionResult Index()
        {
            Kullanici kullanici = new();
            kullanici.Ad = "Azazel";
            kullanici.Soyad = "Jhinn";
            return View(kullanici);
        }
    }
}
