using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.username = "";
            ViewBag.email = "";
            ViewBag.error = false;
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.username = newUser.Username;
            ViewBag.email = newUser.Email;
            if (newUser.Password.Equals(verify))
            {
                return View("Index");
            } else
            {
                ViewBag.error = true;
                return View("Add");
            }
        }
    }
}
