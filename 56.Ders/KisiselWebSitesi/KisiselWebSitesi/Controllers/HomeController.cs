using System.Diagnostics;
using KisiselWebSitesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["KullaniciAdi"] = "Tugay Tuna";
            ViewData["KullaniciAdi"] = "Ahmet";
            ViewBag.TelNo = "05555555";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Gizlilik Sözleþmesi";
            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
