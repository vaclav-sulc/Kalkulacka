using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Procvičování_na_Test
{
    internal class Motorcycle : Vehicle
    {
        private bool hasSidecar;
        
        public Motorcycle(string brand, string model, int year, bool hasSidecar) : base(brand, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public bool HasSidecar { get => hasSidecar; set => hasSidecar = value; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Has sidecar: {HasSidecar}");
        }
        
    }
}
