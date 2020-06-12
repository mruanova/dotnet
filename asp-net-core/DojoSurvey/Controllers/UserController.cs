using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Username = "mruanova";
            User mau = new User();
            mau.FirstName = "Mauricio";
            mau.LastName = "Ruanova";
            return View(mau);
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            Console.WriteLine(user);
            return View(user);
        }

        // In HomeController
        [HttpPost("user/create")]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("SomeAction");
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("NewUser");
            }
        }
    }
}
