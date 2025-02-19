using System.Diagnostics;
using FluentValidation;
using HotelATR.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelATR.RealPortal0.Controllers
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
        public IActionResult contact(Message userMessage)
        {


            //if(string.IsNullOrWhiteSpace(UserMessage.name))
            //{
            //    ModelState.AddModelError("name", "ѕоле об€зательно должно быть заполнено");

            //}
            //if (ModelState.IsValid)
            //{
            //    return View();
            //}
            //else
            //{
            //    return View(UserMessage);
            //}
            //var data = Request.Form;
            //return RedirectToAction("Contact", "home");


            MessageValidator rules = new MessageValidator();
            var result = rules.Validate(userMessage);

            //list vount of errors
            var errors = result.Errors;

            rules.ValidateAndThrow(userMessage);

            if (result.IsValid)
            {
                return View();
            }
            else
            {
                return View(userMessage);
            }

        }

        [HttpPost]
        public IActionResult SendEmail(string email)
        {
            //return RedirectToAction("Contact", "home");
            return View();
        }


        //NewsLetter
        public IActionResult NewsLetterSignUp(string email, string phone)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                ModelState.AddModelError("error", "NANANA");
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }


        }
        public IActionResult Rooms()
        {
            return View();
        }
        public IActionResult Locations()
        {
            return View();
        }

        public JsonResult SetCity(string city)
        {
            try
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(1);

                Response.Cookies.Append("city", city);
                return Json(city);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
    }
}