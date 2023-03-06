using Estate_Expert.Data;
using Estate_Expert.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

namespace Estate_Expert.Controllers
{
    public class UserController : Controller
    {
        private readonly EstateExpertDbContext _db;

        public UserController(EstateExpertDbContext db)
        {
                _db = db;   
        }

        //public IActionResult UserDetail()
        // {
        //     return View();
        // }

        //Get
        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult UserDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var Userobj = _db.userDetail.FirstOrDefault(x => x.userId == id);
            if (Userobj == null)
            {
                return NotFound();
            }

            return View(Userobj);
        }

    }
}
