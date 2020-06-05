using System;

namespace vehicle_inheritance
{
    // Defining a child class of Vehicle
    class Car : Vehicle, IRideable
    {
        // We can add members that are unique to Cars, things that won't describe ALL vehicles
        public string Make;
        public string Model;
        // but when we define a constructor for Car, we need to satisfy any constructor requirements
        // for at least ONE constructor on the parent Vehicle class
        public Car(string color, string make, string model) : base(color)
        {
            Make = make;
            Model = model;
        }
        //All past code for the Car Class should still be present
        public override void GetInfo()
        {
            //Console.WriteLine($"Num Passengers: {NumPassengers}");
            //Console.WriteLine($"Color: {Color}");
            //Console.WriteLine($"Miles: {Odometer}");
            //This line will call the parent's version of this method first 
            base.GetInfo();
            //Then add any additional code to it!
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
        }
        // we can use DistanceTraveled to be a wrapper for "Odometer"
        public double DistanceTraveled
        {
            get { return Odometer; }
            set { Odometer = value; }
        }
        public void Ride(double distance)
        {
            // here we can choose implement this method however we wish
            // as long as we meet the requirements of the method
            Console.WriteLine("... driving ...");
            DistanceTraveled += distance;
        }
    }
}
