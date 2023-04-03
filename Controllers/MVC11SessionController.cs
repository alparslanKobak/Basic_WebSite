using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MVC11SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SessionOlustur(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "admin" && sifre == "123")
            {
                HttpContext.Session.SetString("Kullanici",kullaniciAdi); // session da verileri key = value şeklinde saklıyoruz. 
                HttpContext.Session.SetInt32("IsLoggedIn", 1); // session da string dışında int tipinde veri saklayabilir.
                HttpContext.Session.SetString("UserGuid", Guid.NewGuid().ToString());
                return RedirectToAction("SessionOku");
            }
            return View();
        }

        public IActionResult SessionOku()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SessionSil()
        {
            HttpContext.Session.Remove("Kullanici"); // Yalnızca Kullanıcı isimli sessionu sil

            HttpContext.Session.Clear(); // Tüm sessionları sil

            return RedirectToAction("SessionOku");
        }
    }

}
