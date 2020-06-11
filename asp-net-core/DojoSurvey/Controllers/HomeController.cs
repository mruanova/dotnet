using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Http; // session
using DbConnection; // mysql

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*
            // *Inside controller methods*
            // To store a string in session we use ".SetString"
            // The first string passed is the key and the second is the value we want to retrieve later
            HttpContext.Session.SetString("UserName", "Samantha");
            // To retrieve a string from session we use ".GetString"
            string LocalVariable = HttpContext.Session.GetString("UserName");

            // To store an int in session we use ".SetInt32"
            HttpContext.Session.SetInt32("UserAge", 28);
            // To retrieve an int from session we use ".GetInt32"
            int? IntVariable = HttpContext.Session.GetInt32("UserAge");
            */
            List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
            // To provide this data, we could use ViewBag or a View Model.  ViewBag shown here:
            ViewBag.Users = AllUsers;
            ViewBag.Username = "mruanova";
            User mau = new User();
            mau.FirstName = "Mauricio";
            mau.LastName = "Ruanova";
            return View(mau);
        }
        /*
        // Get One User
        [HttpGet]
        [Route("{userId}")]
        public IActionResult Show(int userId)
        {
            // One user will be represented as an item in the list of dictionaries, shown here by indexing 0
            Dictionary<string, object> User = DbConnector.Query($"SELECT * FROM users WHERE id = {userId}")[0];
            // Other code
        }

        // Create a User
        [HttpPost]
        [Route("create")]
        public IActionResult Create(User user)
        {
            // other code
            string query = $"INSERT INTO users (FirstName, LastName) VALUES ('{user.FirstName}', '{user.LastName}')";
            DbConnector.Execute(query);
            // other code
        }
        */
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
