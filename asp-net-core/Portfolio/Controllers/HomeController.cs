using System;
using Microsoft.AspNetCore.Mvc;

namespace ProjectName
{
    public class HomeController : Controller
    {
        // Requests

        // localhost:5000/
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            // Views/Home/Index.cshtml
            // Views/Shared/Index.cshtml
            // Here we assign the value "Hello World!" to the property .Example
            // Property names are arbitrary and can be whatever you like
            ViewBag.Example = "Here are some delicious foods!";
            return View();
            // if we provide the exact view name
            // View("Info");
        }
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View(); // View("Index");
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View(); // View("Index");
        }
        [HttpPost]
        [Route("submission")]
        // POST requests to "localhost:5000/submission" go here
        // (Don't worry about form submissions for now, we will get to those later!)
        public ActionResult FormSubmission(string formInput)
        {
            return Content("Form Submission");
        }
        // go to /mau
        // <%= Ajax.ActionLink("SomeActionMethod", new AjaxOptions {OnSuccess="somemethod"}) %>
        [HttpGet]
        [Route("{name}")]
        public ActionResult Name(string name)
        {
            return Json(new { foo = "bar", baz = "Blech" });
        }
        [HttpGet]
        [Route("user/{name}/{location}/{age}")]
        public string UserInfo(string name, string location, int age)
        {
            return $"{name}, aged {age}, is from {location}";
        }
        [HttpGet("users")]
        public RedirectToActionResult Users()
        {
            Console.WriteLine("redirecting...");
            // RedirectResult => Redirect
            var param = new { name = "mau", location = "chicago", age = 39 };
            return RedirectToAction("UserInfo", param);
        }
        [HttpGet("hello")]
        public ActionResult SomeActionMethod()
        {
            return Content("hello world!");
        }
        [HttpGet("food")]
        public ViewResult Food()
        {
            // Views/Home/Index.cshtml
            // Views/Shared/Index.cshtml
            // Here we assign the value "Hello World!" to the property .Example
            // Property names are arbitrary and can be whatever you like
            ViewBag.Example = "Here are some delicious foods!";
            return View();
            // if we provide the exact view name
            // View("Info");
        }
    }
}