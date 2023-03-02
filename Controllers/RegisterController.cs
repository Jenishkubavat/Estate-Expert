using Microsoft.AspNetCore.Mvc;
using Estate_Expert.Models;
using Estate_Expert.Data;
namespace Estate_Expert.Controllers;

    public class RegisterController : Controller
    {
    private readonly EstateExpertDbContext _Db;
    public RegisterController(EstateExpertDbContext db)
    {
        _Db = db;
    }
        public IActionResult Index()
        {
            return View();
        }
    [HttpPost]
    [ValidateAntiForgeryToken]
        public IActionResult Register(UserDetailsModel user_Details)
    {
        user_Details.userId = _Db.userDetail.Select(x => x.userId).DefaultIfEmpty().Max()+1;


        if (ModelState.IsValid)
        {
            
            _Db.userDetail.Add(user_Details);
            _Db.SaveChanges();
            return View();
        }
        return View(user_Details);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Login()
    {
        return View("Index", "Home"); ;
    }
}

