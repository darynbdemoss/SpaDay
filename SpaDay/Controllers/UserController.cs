using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /user
        public IActionResult Index()
        {
            return View();
        }

        // GET: /user/add
        public IActionResult Add()
        {
            return View();
        }

        // POST: /user/add
        [HttpPost("/user/add")]
        public IActionResult Create(User user, string verify)
        {
            if (user.Password == verify)
            {
                ViewBag.user = user;
                return View("Index");
            }
            else
            {
                ViewBag.user = user;
                ViewBag.error = "Passwords didn't match !";
                return View("Add");
            }
        }
    }
}
