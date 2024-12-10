using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Procvičování_na_Test
{
    internal class Truck : Car
    {
        private int load;

        public Truck(string brand, string model, int year, int numberOfDoors, int load) : base(brand, model, year, numberOfDoors)
        {
            Load = load;
        }

        public int Load { get => load; set => load = value; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Number of doors: {NumberOfDoors}, Load capacity: {Load}");
        }
    }
}
