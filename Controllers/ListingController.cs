using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class ListingController : Controller
    {
        public IActionResult Listing()
        {
            return View();
        }
    }
}
