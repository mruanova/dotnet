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
    public class SurveyController : Controller
    {
        private readonly ILogger<SurveyController> _logger;

        public SurveyController(ILogger<SurveyController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Surveyname = "mruanova";
            Survey mau = new Survey();
            mau.Name = "Mauricio";
            mau.Location = "Chicago";
            mau.Language = "CSharp";
            mau.Comment = "Ruanova";
            return View(mau);
        }

        [HttpPost("surveys")]
        public IActionResult Surveys(Survey survey)
        {
            Console.WriteLine(survey);
            return View(survey);
        }
    }
}
