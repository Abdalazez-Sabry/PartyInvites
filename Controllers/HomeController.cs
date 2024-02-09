using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers{
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            if (!ModelState.IsValid) {
                return View();
            }

            Reposiotry.AddResopnse(guestResponse);
            return View("Thanks", guestResponse);
        }

        public ViewResult ListResponses() {
            return View(Reposiotry.Responses.Where (r => r.WillAttend == true));
        }
    }
}