using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sonu_core.Models;
using Sonu_core.Models.LoginViewMOdel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Sonu_core.Controllers
{
    public class LoginController : Controller
    {
        private readonly studentContext _db;
        public LoginController(studentContext db)
        {
            _db = db;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Login s)
        {
            if (ModelState.IsValid)
            {
                var res = _db.Logins.Add(s);
                _db.SaveChanges();
                return RedirectToAction("Signup");
            }
            else
            {
                return View();
            }

        }
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(SignupViewModel s)
        {
            var res = _db.Logins.Where(a => a.Email == s.Email && a.password == s.password).FirstOrDefault();
            if(res != null)
            {
                return RedirectToAction("index");
               
            }
            else
            {
                return View();
            }
            
        }
    }
}
