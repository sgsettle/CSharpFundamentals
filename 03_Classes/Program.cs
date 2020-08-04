using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // New up my Vehicle instance
            Vehicle firstVehicle = new Vehicle();
            // creates an instance of a Vehicle 
            // cookie cutter way of giving information to a class
            // Vehicle class (Vehicle.cs) is what it should look like, constructor below is giving it definitions

            // Setting Make property in my firstVehicle instance
            firstVehicle.Make = "Honda";
            // Getting my Make property from firstVehicle and writing to console
            Console.WriteLine(firstVehicle.Make);
            // Setting rest of properties
            firstVehicle.Model = "Civic";
            firstVehicle.Mileage = 12345.67d;
            firstVehicle.TypeOfVehicle = VehicleType.Car;
            // Writing a string by getting all of our properties
            Console.WriteLine($"I own a {firstVehicle.Make} {firstVehicle.Model} and it has {firstVehicle.Mileage} miles on it.");

            Vehicle car = new Vehicle("Toyota", "Corola", 213000, VehicleType.Car);
            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 3000000, VehicleType.Spaceship);

            Console.WriteLine(rocket.Model);

            Person instructor = new Person();
            instructor.FirstName = "Slayde";
            instructor.LastName = "Settle";
            instructor.DateOfBirth = new DateTime(1991, 10, 30);
            Console.WriteLine(instructor.FullName);
            Console.WriteLine(instructor.Age);

            instructor.Transport = firstVehicle;
            Console.WriteLine(instructor.Transport.TypeOfVehicle);

            instructor.SayHello();

            Person student = new Person();
            student.FirstName = "Wes";
            student.LastName = "Winn";

            instructor.SayHello(student.FirstName);
            instructor.SayHello(student);

            Console.ReadLine();
        }
    }
}
