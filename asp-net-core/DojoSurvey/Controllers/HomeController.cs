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
            Product[] myProducts = new Product[]
            {
                new Product { Name = "Jeans", Category = "Clothing", Price = 24.7 },
                new Product { Name = "Socks", Category = "Clothing", Price = 8.12 },
                new Product { Name = "Scooter", Category = "Vehicle", Price = 99.99 },
                new Product { Name = "Skateboard", Category = "Vehicle", Price = 24.99 },
                new Product { Name = "Skirt", Category = "Clothing", Price = 17.5 }
            };
            Console.WriteLine(myProducts);
            // sort
            // The lambda here uses a variable 'prod' which represents a product 
            // (although this may be named whatever you like)  
            //  The right hand side of the arrow is selecting Price as the thing we want to order by.
            IEnumerable<Product> orderedProducts = myProducts.OrderByDescending(prod => prod.Price);
            Console.WriteLine(orderedProducts);
            // filter
            // Each "Product" in the array will be tested to see if its Category property matches the string "Clothing"
            // If it matches (if the bool returns true) it will "pass the test" and be included in the result
            IEnumerable<Product> justClothings = myProducts.Where(prod => prod.Category == "Clothing");
            Console.WriteLine(justClothings);
            // first or default
            Product justJeans = myProducts.FirstOrDefault(prod => prod.Name == "Jeans");
            Console.WriteLine(justJeans);
            // FirstOrDefault can be used with no argument, as well, which will just retrieve the first item in the collection
            Product firstOne = myProducts.FirstOrDefault();
            Console.WriteLine(firstOne);
            // select
            IEnumerable<string> justCategories = myProducts.Select(prod => prod.Category);
            Console.WriteLine(justCategories);

            // min max sum
            int[] numbers = new int[] { 12, 4, 5, 2, 5, -1 };
            int smallestNum = numbers.Min();
            int largestNum = numbers.Max();
            int sumOfNums = numbers.Sum();
            // Ok, this makes sense for integers, but what about the .Sum of a Product?
            // You can use a "selector" lambda as an overload for these methods to determine how something like .Sum could be calculated
            double sumOfProductPrice = myProducts.Sum(prod => prod.Price);

            // to list / to array
            List<Product> highTicketItemList = myProducts.Where(p => p.Price > 100).ToList();
            Product[] orderedProductArray = myProducts
                 .Where(p => p.Category == "Clothing")
                 .OrderBy(p => p.Price)
                 .ToArray();

            // join
            List<string> Food = new List<string>
            {
                "apple",
                "banana",
                "carrot",
                "fudge",
                "tomato"
            };
            List<string> Adjective = new List<string>
            {
                "tasty",
                "capital",
                "best",
                "typical",
                "flavorful",
                "toothsome"
            };

            // each string in the Food list will be combined with each adjective from the Adjective list where their first characters match
            IEnumerable<string> Alliterations = Food.Join(Adjective,
                foodItem => foodItem[0],
                adjective => adjective[0],
                (foodItem, adjective) =>
                {
                    return adjective + " " + foodItem;
                });

            //Combo:   "best banana",
            //         "capital carrot",
            //         "flavorful fudge",
            //         "tasty tomato",
            //         "typical tomato",
            //         "toothsome tomato"

            // Notice that apple is not in the combination collection because it does not match an adjective, but tomato occurs three times because it matched three different adjectives

            // session
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
