using Microsoft.AspNetCore.Mvc;

namespace DevHobby.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
