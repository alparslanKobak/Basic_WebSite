using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class MVC05ModelValidationController : Controller
    {
        UyeContext context = new UyeContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UyeListesi()
        {
            var model = context.Uyes.ToList(); // context içinde yer alan uyes tablosundaki verileri listele ve model isimli değişkene aktar.

            return View(model); //view sayfasına model bu şekilde gönderiliyor.
        }

        public IActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid) // Eğer parantez içerisindde gönderilen üye nesnesi doğrulama yani validasyon kurallarına uygun ise 
            {
                // Bu bloktaki kodları çalıştır. Örneğin gönderilen üye nesnesini veritabanına ekle.
                context.Uyes.Add(uye); // View'dan gönderilen üye nesnesini context üzerindeki uyes tablosuna ekle.
                context.SaveChanges(); // Üst satırdaki ekleme işlemini kaydet. Kaydetme işlemi olmazsa değişiklikler kaybolur.

                return RedirectToAction("UyeListesi");
            }
            else
            {
                ModelState.AddModelError("", " Lütfen Zorunlu Alanları Doldurunuz");
            }
            return View();
        }


        public IActionResult UyeDuzenle(int id)
        {

            var kayit = context.Uyes.Find(id); // adres çubuğundaki route üzerinden gönderilen id ile eşleşen kaydı bul.

            return View(kayit);
        }
        [HttpPost]
        public IActionResult UyeDuzenle(Uye uye)
        {
            if (ModelState.IsValid) // Eğer parantez içerisindde gönderilen üye nesnesi doğrulama yani validasyon kurallarına uygun ise 
            {
                // Bu bloktaki kodları çalıştır. Örneğin gönderilen üye nesnesini veritabanına ekle.
                context.Uyes.Update(uye); // View'dan gönderilen üye nesnesini güncelle 

                context.SaveChanges(); // Üst satırdaki ekleme işlemini kaydet. Kaydetme işlemi olmazsa değişiklikler kaybolur.

                return RedirectToAction("UyeListesi");
            }
            else
            {
                ModelState.AddModelError("", " Lütfen Zorunlu Alanları Doldurunuz");
            }
            return View();
        }

        public IActionResult UyeSil(int id)
        {

            var kayit = context.Uyes.Find(id); // adres çubuğundaki route üzerinden gönderilen id ile eşleşen kaydı bul.

            return View(kayit);
        }
        [HttpPost]
        public IActionResult UyeSil(Uye uye)
        {

            try
            {
                context.Uyes.Remove(uye); // View'dan gönderilen üye nesnesini sil.

                context.SaveChanges(); // Üst satırdaki ekleme işlemini kaydet. Kaydetme işlemi olmazsa değişiklikler kaybolur.

                return RedirectToAction("UyeListesi");
            }
            catch (Exception e)
            {

                ModelState.AddModelError("","Hata oluştu. " + e.Message);
            }

            return View(uye);
        }
    }
}
