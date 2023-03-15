using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MVC04ModelBindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult KullaniciDetay()
        {
            Kullanici kullanici = new ();
            kullanici.KullaniciAdi = "Admin";
            kullanici.Ad = "Alparslan";
            kullanici.Soyad = "Kobak";
            kullanici.Sifre = "123";
            kullanici.Email = "alparslankobak@gmail.co";

            return View(kullanici); // View içerisinde model datası olarak kullanici nesnesini sayfaya gönderdik.
        }
        [HttpPost]
        public IActionResult KullaniciDetay(Kullanici kullanici) // Post metodunda modelden gelen nesneyi bu şekilde parantez içinde yakalayabiliyoruz.
        {

            return View(kullanici); // gelen kullanici nesnesini tekrardan ekrana yollayabiliyoruz.
        }

        public IActionResult AdresDetay()
        {
            Adres adres = new()
            {
                Sehir = "Çankırı",
                Ilce = "Çerkeş",
                AcikAdres = "Hüptürik.sk"
            };
            return View(adres);
        } // Post ile yakalama eklenecek...

        public IActionResult UyeSayfasi()
        {
            Kullanici kullanici = new();
            kullanici.KullaniciAdi = "Admin";
            kullanici.Ad = "Alparslan";
            kullanici.Soyad = "Kobak";
            kullanici.Sifre = "123";
            kullanici.Email = "alparslankobak@gmail.co";

            Adres adres = new()
            {
                Sehir = "Bursa",
                Ilce = "Osmangazi",
                AcikAdres = "Hüptürik.sk"
            };

            var model = new UyeSayfasiViewModel()
            {
                Kullanici = kullanici, 
                Adres = adres
            };
            return View(model);
        }

    }
}
