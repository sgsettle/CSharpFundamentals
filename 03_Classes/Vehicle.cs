using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat };
    // Enum is a list of constants or information that will never change

    public class Vehicle
    {
        // Constructor
        public Vehicle() { }
        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
        }
        // need to make public so it can be used outside of this class

        // Properties
        // Describe what classes look like
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
    }
}
