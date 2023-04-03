using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication1.Filters
{
    public class UserControl : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Aksiyonun yürütüldüğü bağlamı kullan = Action Executing Context

            var userGuid = context.HttpContext.Session.GetString("UserGuid"); // uygulamanın çalıştığı ekrandaki UserGuid isimli session ı yakala.

            var userCookie = context.HttpContext.Request.Cookies["userGuid"]; // cookie yi yakala

            if (userGuid == null)
            {
                context.Result = new RedirectResult("/MVC11Session?msg=AccessDenied");
            }

            base.OnActionExecuting(context);
        }
    }
}
