using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            auto Auto = new auto("Skoda", 200, 5, 5);
            motorka Motorka = new motorka("Yamaha", 150, 2, 2);
            Auto.vypis();
            Motorka.vypis();
        }
    }
}
