using Microsoft.AspNetCore.Mvc;

namespace lab_4.Controllers
{
    public class AdminController : Controller
    {
        [Route("admin")]
        public IActionResult AdminPage()
        {
            return View();
        }
    }
}
