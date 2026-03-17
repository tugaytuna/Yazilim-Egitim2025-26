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
            ViewData["KullaniciAdi"] = "Tugay Tuna";
            ViewBag.TelNo = "0555555555";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Gizlilik Sözleþmesi";
            return View();
        }

        public IActionResult AboutMe()
        {
            Console.WriteLine("Home controller altýndaki AboutMe tetiklendi!");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
