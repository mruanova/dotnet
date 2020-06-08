using Microsoft.AspNetCore.Mvc;

namespace ProjectName
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        [Route("")]
        [HttpGet]
        public string Index()
        {
            return "This is my Index!";
        }
        // localhost:5000/projects
        [Route("projects")]
        [HttpGet]
        public string Projects()
        {
            return "These are my projects!";
        }
        // localhost:5000/contact
        [Route("contact")]
        [HttpGet]
        public string Contact()
        {
            return "This is my Contact!";
        }
        /*
        // localhost:5000/
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        [Route("submission")]
        // POST requests to "localhost:5000/submission" go here
        // (Don't worry about form submissions for now, we will get to those later!)
        public string FormSubmission(string formInput)
        {
            return "form submit!";
        }
        // Other code [Route("users/{userName}"].  
        [HttpGet]
        [Route("{name}")]
        public string Index(string name)
        {
            return $"Hello {name}!";
        }
        [HttpGet]
        [Route("pizza/{topping}")]
        public string PizzaParty(string topping)
        {
            return $"Who's ready for a {topping} Pizza!";
        }
        [HttpGet]
        [Route("user/{name}/{location}/{age}")]
        public string UserInfo(string name, string location, int age)
        {
            return $"{name}, aged {age}, is from {location}";
        }
        */
    }
}