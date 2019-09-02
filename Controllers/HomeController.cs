using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Librarymanagement.Models;

namespace Librarymanagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Registration lm)
        {
            if (ModelState.IsValid)
            {
                Library libb = new Library();
                string message = libb.Register(lm);
                if (message == "Registered")
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.UserExists = message;
                }
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserDetails Ud)
        {
            if (ModelState.IsValid)
            {
                Library libb = new Library();
                UserDetails user = libb.Login(Ud.MailId,Ud.Password);
                if (user.UserId > 0)
                {
                    if(user.Role == "admin")
                    {
                        return View("admin",user);
                    }
                    else
                    {
                        return RedirectToAction("user", user);
                    }                    
                }
                else
                {
                    ViewBag.InvalidCredentials = "Invalid User Credentials";
                }                
            }
            return View();
        }

        public ActionResult User(UserDetails user)
        {
            return View(user.UserId);
        }
        
        public ActionResult Admin()
        {
            return View();
        }
    }
}