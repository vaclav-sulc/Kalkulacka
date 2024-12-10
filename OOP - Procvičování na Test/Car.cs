using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Procvičování_na_Test
{
    internal class Car : Vehicle
    {
        private int numberOfDoors;

        public Car(string brand, string model, int year, int numberOfDoors) : base(brand, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Number of doors: {NumberOfDoors}");
        }
    }
}
