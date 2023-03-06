using Estate_Expert.Data;
using Estate_Expert.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace Estate_Expert.Controllers
{
    public class HomeController : Controller
    {
        private readonly EstateExpertDbContext _Db;
        public HomeController(EstateExpertDbContext db)
        {
            _Db = db;
        }
        

        public IActionResult Index()
        {
            return View();
        }
        [ActionName("UserIndex")]
        public IActionResult Index(UserDetailsModel user)
        {
            return View(user);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserDetailsModel newUser)
        {
            //var errors = ModelState.Where(a => a.Value.Errors.Count > 0)
            //  .Select(b => new { b.Key, b.Value.Errors })
            //  .ToArray();

            //foreach (var modelStateErrors in errors)
            //{
            //    System.Diagnostics.Debug.WriteLine("...Errored When Binding.", modelStateErrors.Key.ToString());

            //}
            newUser.UserId = _Db.UserDetails.Select(x => x.UserId).DefaultIfEmpty().Max() + 1;
            if (ModelState.IsValid)
            {

                _Db.UserDetails.Add(newUser);
                _Db.SaveChanges();
                return RedirectToAction("UserIndex",newUser);
            }
            return View(newUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserDetailsModel logdetails)
        {
           var user = _Db.UserDetails.FirstOrDefault(x=>x.UserName== logdetails.UserName);
            if (user == null)
            {
                ModelState.AddModelError("UserName", "The user name does not exist");
            }
           else if (logdetails.UserPassword!=user.UserPassword)
            {
                ModelState.AddModelError("UserPassword", "Pasword does not match");
            }
            if (ModelState.IsValid)
            {
                SignInLogModel signIn = new SignInLogModel();
                signIn.LogId = _Db.SignInLogs.Select(x => x.UserId).DefaultIfEmpty().Max() + 1;
                signIn.UserId = user.UserId;
                _Db.SignInLogs.Add(signIn);
                _Db.SaveChanges();
                return RedirectToAction("Index", user);
            }
            else
            {
                return View("Register", logdetails);
            }
                
            
        }


    }
}