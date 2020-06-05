using System;

namespace vehicle_inheritance
{
    class Vehicle
    {
        public int NumPassengers;
        public string Color;
        // Now Car access Odometer! (not private)
        protected double Odometer;
        // Say Vechicle has two overloaded constructors
        // We will either need to pass up two values (int, string), from Car ...
        public Vehicle(int numPas, string col)
        {
            NumPassengers = numPas;
            Color = col;
            Odometer = 0;
        }
        // Or just one string value.  
        public Vehicle(string col)
        {
            NumPassengers = 5;
            Color = col;
            Odometer = 0;
        }
        //All past code for the Car Vehicle should still be present
        public virtual void GetInfo()
        {
            Console.WriteLine($"Num Passengers: {NumPassengers}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Miles: {Odometer}");
        }
    }
}
