using System;
using System.Collections.Generic;

namespace vehicle_inheritance
{
    class Person
    {
        public List<Vehicle> OwnedVehicles;

        public string Name;
        // Any class that implements IRideable can be used!copy
        public IRideable Transport;
        public double Miles;

        public Person()
        {
            OwnedVehicles = new List<Vehicle>();
        }

        public Person(string name, IRideable trans)
        {
            Name = name;
            Transport = trans;
            Miles = 0;
        }

        // can add ANY type of vehicle
        public void AddToVehicles(Vehicle newVehicle)
        {
            OwnedVehicles.Add(newVehicle);
        }

        // can call DisplayInfo() on all vehicles, if DisplayInfo() is overridden on a child class,
        // we will see the child's own implementation!
        public void DisplayVehicles()
        {
            foreach (Vehicle v in OwnedVehicles)
            {
                v.GetInfo();
            }
        }
        // Person can make use of the capabilities of their "transport"
        public void GoSomewhere(double miles)
        {
            Transport.Ride(miles);
            Miles += Transport.DistanceTraveled;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Miles Traveled: {Miles}");
        }
    }
}
