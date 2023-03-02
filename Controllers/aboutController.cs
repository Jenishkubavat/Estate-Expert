using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class aboutController : Controller
    {
        public IActionResult about()
        {
            return View();
        }
    }
}
