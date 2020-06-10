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
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Studentname = "mruanova";
            Student mau = new Student();
            mau.Name = "Mauricio";
            mau.House = "Ruanova";
            return View(mau);
        }

        // other code ...
        [HttpPost("list")]
        public IActionResult List(Student student)
        {
            // process the form...
            Console.WriteLine(student);
            return View(student);
        }
    }
}
