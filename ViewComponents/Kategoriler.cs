using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class Kategoriler : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            // Database ye bağlanıp kategorileri çekip componente gönderebiliriz.

            return View();
        }
    }
}
