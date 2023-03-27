using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MVC10CookieController : Controller
    {
        UyeContext context = new();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CookieOlustur(string kullaniciAdi, string sifre)
        {
            var kullanici = context.Uyes.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi && k.Sifre == sifre);
            if (kullanici!= null)
            {
                // girilen bilgilerle eşleşen kullanıcı varsa.
            }

            if (kullaniciAdi == "admin" && sifre == "123")
            {
                CookieOptions cookieAyarlari = new()
                {
                    Expires = DateTime.Now.AddMinutes(1) // bu ayarları kullanarak oluşturacağımız cookie ye 1dk lık yaşam süresi belirledik.
                };
                Response.Cookies.Append("kullaniciAdi", kullaniciAdi, cookieAyarlari);
                Response.Cookies.Append("sifre", sifre, cookieAyarlari);
                Response.Cookies.Append("userguid", Guid.NewGuid().ToString()); // Guid.NewGuid() metoduyla kullanıcıya özel benzersiz bir numara oluşturduk.
                return RedirectToAction("CookieOku");
            }
            else
            {
                TempData["Mesaj"] = @"<div class='alert alert-danger'>Giriş Başarısız! </div>";
            } 
            return View("Index");
        }

        public IActionResult CookieOku()
        {
            if (Request.Cookies["userguid"] == null) // Controller da cookilere bu şekilde ulaşabiliriz.
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult CookieSil()
        {
            Response.Cookies.Delete("kullaniciAdi");
            Response.Cookies.Delete("sifre");
            Response.Cookies.Delete("userguid");
            return RedirectToAction("CookieOku");
        }


    }
}
