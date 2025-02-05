using HotelATR.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelATR.RealPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        //public IActionResult AddMessage(string name, string email, string message)
        public IActionResult AddMessage(Message UserMessage)
        {
            var data = Request.Form;
            return RedirectToAction("Contact", "home");
            //return View();
        }
        [HttpPost]
        public IActionResult NewsLetter(string email)
        {
            return View();
        }
    }
}
