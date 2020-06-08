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
            return "hello from controller";
        }
        
        // localhost:5000/hello
        [Route("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hello World!";
        }
    }
}