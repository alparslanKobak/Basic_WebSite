﻿using Microsoft.AspNetCore.Mvc;

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
            if (kullaniciAdi == "Admin" && sifre == "123")
            {

            }
            return View();
        }
    }
}