using System;
using System.ComponentModel.DataAnnotations;
 
namespace DojoSurvey.Models
{
    public class Car
    {
        public string Name { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
    }
}