using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MauDotNetCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;

namespace MauDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly ILogger<HomeController> _logger;
        private MauContext dbContext;
        public HomeController(ILogger<HomeController> logger, MauContext context)
        {
            _logger = logger;
            dbContext = context;
        }

        public IActionResult Index()
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };
            var query = fruits.Select((fruit, index) => new
            {
                index,
                str = fruit.Substring(0, index)
            });
            foreach (var obj in query)
            {
                Console.WriteLine("{0}", obj);
            }
            /*
             This code produces the following output:
             {index=0, str=}
             {index=1, str=b}
             {index=2, str=ma}
             {index=3, str=ora}
             {index=4, str=pass}
             {index=5, str=grape}
            */

            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);
            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }
            /*
             This code produces the following output:
             1
             4
             9
             16
             25
             36
             49
             64
             81
             100
            */

            // Get all Users
            List<User> AllUsers = dbContext.Users.ToList();
            Console.WriteLine(AllUsers);

            // Get Users with the LastName "Jefferson"
            List<User> mau = dbContext.Users.Where(u => u.LastName == "rua").ToList();
            Console.WriteLine(mau);

            // Get the 5 most recently added Users
            List<User> MostRecent = dbContext.Users
                .OrderByDescending(u => u.CreatedAt)
                .Take(5)
                .ToList();
            Console.WriteLine(MostRecent);

            // email
            User oneUser = dbContext.Users.FirstOrDefault(user => user.Email == "mau@rua.com");
            Console.WriteLine(oneUser);

            // var stringData = await _httpClient.GetStringAsync(URL);

            return View();
        }
        
        // public async Task<int> GetDotNetCount()
        [HttpGet, Route("projects")]
        public async void GetProjects()
        {
            // Suspends GetDotNetCount() to allow the caller (the web server)
            // to accept another request, rather than blocking on this one.
            string URL ="https://246gg84zg8.execute-api.us-west-2.amazonaws.com/prod/projects";
            var html = await _httpClient.GetStringAsync(URL);
            // return Regex.Matches(html, @"\.NET").Count;
            /*
            await Task.WhenAny	Task.WaitAny	Waiting for any task to complete
            await Task.WhenAll	Task.WaitAll	Waiting for all tasks to complete
            await Task.Delay	Thread.Sleep	Waiting for a period of time
            */
        }

        [HttpGet]
        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        [Route("success")]
        public IActionResult Success()
        {
            return View("Index");
        }

        [HttpPost("success")]
        public IActionResult Success(LoginUser userSubmission)
        {
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                }
                else
                {
                    // Initialize hasher object
                    var hasher = new PasswordHasher<LoginUser>();

                    // verify provided password against hash stored in db
                    var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);

                    // result can be compared to 0 for failure
                    if (result == 0)
                    {
                        // handle failure (this should be similar to how "existing email" is handled)
                    }
                }
            }
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            // Check initial ModelState
            if (ModelState.IsValid)
            {
                // If a User exists with provided email
                if (dbContext.Users.Any(u => u.Email == user.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);

                    var maxItem =
                               dbContext.Users.OrderByDescending(i => i.UserId).FirstOrDefault();
                    var newID = maxItem == null ? 1 : maxItem.UserId + 1;
                    user.UserId = newID; // auto generate

                    dbContext.Add(user);
                    // OR dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();
                    return View("Success", user);
                }
            }
            return View("Index", user);
        }

        [HttpGet("update/{userId}")]
        public IActionResult UpdateUser(int userId)
        {
            // We must first Query for a single User from our Context object to track changes.
            User RetrievedUser = dbContext.Users.FirstOrDefault(user => user.UserId == userId);
            // Then we may modify properties of this tracked model object
            RetrievedUser.FirstName = "New name";
            RetrievedUser.UpdatedAt = DateTime.Now;

            // Finally, .SaveChanges() will update the DB with these new values
            dbContext.SaveChanges();
            return View();
        }

        [HttpGet("delete/{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            // Like Update, we will need to query for a single user from our Context object
            User RetrievedUser = dbContext.Users.SingleOrDefault(user => user.UserId == userId);

            // Then pass the object we queried for to .Remove() on Users
            dbContext.Users.Remove(RetrievedUser);

            // Finally, .SaveChanges() will remove the corresponding row representing this User from DB 
            dbContext.SaveChanges();
            return View();
        }

        [HttpGet("person/{personId}")]
        public IActionResult Show(int personId)
        {
            var personWithSubsAndMags = dbContext.Persons
                .Include(person => person.Subscriptions)
                .ThenInclude(sub => sub.Magazine)
                .FirstOrDefault(person => person.PersonId == personId);

            return View(personWithSubsAndMags);
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
