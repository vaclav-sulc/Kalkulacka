using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Procvičování_na_Test
{
    public static class VehicleHelper
    {
        public static int CalculateVehicleAge(Vehicle vehicle)
        {
            return 2024 - vehicle.Year;
        }

        public static bool IsClassicCar(Vehicle vehicle)
        {
            if (CalculateVehicleAge(vehicle) >= 30)
            {
                return true;
            }
            else { return false; }

        }
    }
}
