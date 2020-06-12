using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MauDotNetCore.Models;

namespace MauDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MauContext dbContext;
        public HomeController(ILogger<HomeController> logger, MauContext context)
        {
            _logger = logger;
            dbContext = context;
        }
        // [HttpGet]
        // [Route(""copy)]
        public IActionResult Index()
        {
            // Get all Users
            List<User> AllUsers = dbContext.Users.ToList();
    
			// Get Users with the LastName "Jefferson"
			List<User> Jeffersons = dbContext.Users.Where(u => u.LastName == "Jefferson").ToList();
            
    		// Get the 5 most recently added Users
            List<User> MostRecent = dbContext.Users
    			.OrderByDescending(u => u.CreatedAt)
    			.Take(5)
    			.ToList();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
