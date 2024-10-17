using Microsoft.AspNetCore.Mvc;

namespace lab_4.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("login")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Authenticate(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return RedirectToAction("AdminPage", "Admin");
            }
            else
            {
                ViewBag.ErrorMessage = "Неверный логин или пароль.";
                return View("Index");
            }
        }


     
    }
}
