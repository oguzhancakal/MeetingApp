using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index ()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            int UserCount = Repository.Users.Where(i =>i.WillAttend == true).Count();
            
            var meetinInfo = new MeetingInfo(){
                Id = 1,
                Location = "İstanbul, ABC Kongre Merkezi",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = UserCount,
            };
            
            return View(meetinInfo);
        }
    }
}