using Microsoft.AspNetCore.Mvc;

namespace Estate_Expert.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
