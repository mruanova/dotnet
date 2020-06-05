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
            // Vehicle someVehicle = new Vehicle("Green");

            // Constructing a Car "as a" Vehicle
            Vehicle carAsVehicle = new Car("Yellow", "Dodge", "Dart");

            // Constructing a couple Cars
            // Car someCar = new Car("Red", "Toyota", "Corolla");
            Car someOtherCar = new Car("Purple", "Ford", "Fiesta");

            // Constructing a Person, adding any Vehicle to their list of OwnedVehicles
            Person somePerson = new Person();
            somePerson.AddToVehicles(someVehicle);
            somePerson.AddToVehicles(carAsVehicle);
            somePerson.AddToVehicles(someCar);
            somePerson.AddToVehicles(someOtherCar);

            // Calling DisplayVehicles!
            somePerson.DisplayVehicles();
        }
    }
}
