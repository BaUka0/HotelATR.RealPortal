using HotelATR.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

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
        public IActionResult contact(Message UserMessage)
        {

            MessageValidator rules = new MessageValidator();
            var result = rules.Validate(UserMessage);

            var errors = result.Errors;

            //if (string.IsNullOrWhiteSpace(UserMessage.name))
            //{
            //    ModelState.AddModelError("name", "ѕоле об€зательно должно быть заполнено");

            //}
            if (result.IsValid)
            //if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View(UserMessage);
            }
            //var data = Request.Form;
            //return RedirectToAction("Contact", "home");
            //return View();
        }
        [HttpPost]
        public IActionResult NewsLetterSignUp(string email, string phone)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                ModelState.AddModelError("email", "ѕолу об€зательно должно быть заполнено");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Contact");
            }

        }
    }
}
