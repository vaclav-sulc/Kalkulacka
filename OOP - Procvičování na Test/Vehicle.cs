using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Procvičování_na_Test
{
    public abstract class Vehicle
    {
        private string brand;
        private string model;
        private int year;

        protected Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }

        public abstract void DisplayInfo();
    }
}
