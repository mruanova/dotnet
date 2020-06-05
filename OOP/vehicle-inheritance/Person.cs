using System.Collections.Generic;

namespace vehicle_inheritance
{
    class Person
    {
        public List<Vehicle> OwnedVehicles;

        public Person()
        {
            OwnedVehicles = new List<Vehicle>();
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
    }
}
