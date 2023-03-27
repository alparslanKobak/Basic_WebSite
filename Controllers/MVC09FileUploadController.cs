using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MVC09FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile? Image) // ön yüzdeki file elementinin ismini buradaki IFormFile parametresine veriyoruz.

            // IFormFile? a ? koymamızın sebebi post yapılırken resim yüklenmeyebilir, sadece inputlardan veri göndermek isteyebilir.
        {
            if (Image != null)
            {
                string directory = Directory.GetCurrentDirectory() + "/wwwroot/Images/" + Image.FileName;
                using var stream = new FileStream(directory, FileMode.Create); // Seçilen dosyayı pc den sunucuya gönderecek bir akış oluşturduk.

                Image.CopyTo(stream);

                TempData["Resim"] = Image.FileName;
            }
            return View();
        }
    }
}
