using HotelATR.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelATR.RealPortal.Controllers
{
    public class TeamsController : Controller
    {
        public IActionResult Index()
        {
            List<TeamsViewModel> teams = new List<TeamsViewModel>();
            teams.Add(
                new TeamsViewModel(){
                    ImagePath = "img/team/1.jpg",
                    FullName = "Kathy Luis",
                    Position = "( Officer )",
                    Description = "Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse",
                    TeamLinks = new List<Teamlinks> {
                        new Teamlinks()
                        { 
                            URL="https://www.facebook.com/", 
                            LinkType="zmdi zmdi-facebook"
                        },
                        new Teamlinks()
                        {
                            URL = "https://twitter.com/",
                            LinkType = "zmdi zmdi-twitter"
                        },
                        new Teamlinks()
                        {
                            URL = "https://www.pinterest.com/",
                            LinkType = "zmdi zmdi-pinterest"
                        }
                    }
                }); 

            return View();
        }
    }
}
