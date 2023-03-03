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

        public IActionResult Update(int uid=1)
        {
            IEnumerable<UserDetailsModel> model;
           model = _db.userDetail.Where(x=>x.userId== uid).ToList();
            return View(model);
        }
        
    }
}
