using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        public IActionResult Index(string Ara)
        {
            // MVC de temel olarak 3 farklı yöntemle ekrana veri gönderebiliriz.

            // 1- ViewBag : Tek kullanımlık ömrü var 
            ViewBag.UrunKategorisi = "Bilgisayar";

            // 2- ViewData : Tek kullanımlık ömrü var
            ViewData["UrunAdi"] = "Dizüstü Bilgisayar";

            // 3- TempData : İki kullanımlık ömrü var
            TempData["Urun Fiyatı"] = 9999;

            ViewBag.GetVerisi = Ara;

            return View();


        }


        [HttpPost] // Aşağıdaki metot post işleminde çalışsın.
        // namedeki kısımları parametre olarak gireriz.
        public IActionResult Index(string text1, string ddliste, bool cbOnay)
        {

            ViewBag.BirinciYontem = "1. Yöntemle(Parametrelerden gelen veriler)";
            ViewBag.Mesaj = "Textbox'tan gelen veri : " + text1;
            ViewBag.MesajListe = "ddListe'den gelen veri : " + ddliste;
            TempData["Tdata"] = "cbOnay'dan gelen değer : " + cbOnay;


            return View();
        }
    }
}
