using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Procvičování_na_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car("BMW", "M3", 1970, 2));
            vehicles.Add(new Motorcycle("Yamaha", "B5", 2000, true));
            vehicles.Add(new Truck("Volvo", "FH", 2010, 2005, 10000));

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine($"Is classic car: {VehicleHelper.IsClassicCar(vehicle)}");
            }
        }
    }
}
