using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MVC08ViewResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Yonlendir(string arananDeger)
        {
            // Bu action tetiklendiğinde uygulama anasayfaya gitsin.
            return Redirect("https://getbootstrap.com/docs/5.3/getting-started/introduction/"); // Burada ? işaretinden sonraki kısım querrystring yöntemiyle adres çubuğu üzerinden veri yollamak için kullanılır. 

            //Redirect ile de istediğimiz sayfaya yönlendirme verebiliriz.
        }

        public IActionResult ActionaYonlendir()
        {

            // return RedirectToAction("Index"); // Metot çalıştığında aynı kontrollerdeki bir actiona yönlendirmemizi sağlar.

            return RedirectToAction("Index", "Home"); // Metot çalıştığında farklı bir controllerdaki actiona bu şekilde yönlendirebiliriz.
        }

        public RedirectToRouteResult RouteYonlendir() // IActionResult da yapsaydık olurdu.
        {

            return RedirectToRoute("Default", new { controller = "Home", action = "Index", Id = 18 }); // metot çalıştığında route sistemiyle yönlendirme yapmamızı sağlar.
        }

        public PartialViewResult KategorileriGetirPartial() // IActionResult da yapsaydık olurdu.
        {
            return PartialView("_KategorilerPartial");
        }
    }
}
