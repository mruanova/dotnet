using System;

namespace vehicle_inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vehicle!");
            Vehicle someVehicle = new Vehicle("Green");
            Car someCar = new Car("Yellow", "Dodge", "Dart");
            someVehicle.GetInfo();
            someCar.GetInfo();
        }
    }
}
