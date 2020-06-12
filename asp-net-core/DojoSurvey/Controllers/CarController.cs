using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurvey.Models;
using DojoSurvey.Factory;

namespace DojoSurvey.Controllers
{
    public class CarController : Controller
    {
        private readonly ILogger<CarController> _logger;

        private readonly CarFactory _carFactory;

        public CarController(ILogger<CarController> logger, CarFactory uFactory)
        {
            _logger = logger;
            _carFactory = uFactory;
            // _carFactory = new CarFactory();
        }

        public IActionResult Index()
        {
            Car mau = new Car();
            mau.Name = "Sakura";
            mau.Make = "Nissan";
            mau.Year = 2020;
            return View(mau);
        }

        [HttpGet("cars")]
        public IActionResult Cars(Car car)
        {
            ViewBag.Cars = _carFactory.FindAll();
            // List<Car> cars = _carFactory.FindAll();
            return View();
        }
    }
}