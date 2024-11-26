using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auta
{
    public class vozidlo
    {
        public string vyrobce;
        public int rychlost;
        public int pocetSedadel;

        public vozidlo(string vyrobce, int rychlost, int pocetSedadel)
        {
            this.vyrobce = vyrobce;
            this.rychlost = rychlost;
            this.pocetSedadel = pocetSedadel;
        }

        public virtual void vypis()
        {
            Console.WriteLine("Auto vyrobce {0} jede rychlosti {1} km/h a ma {2} sedadel", vyrobce, rychlost, pocetSedadel);
        }
    }

    public class auto : vozidlo
    {
        public int pocetDveri;
        public auto(string vyrobce, int rychlost, int pocetSedadel, int pocetDveri) : base(vyrobce, rychlost, pocetSedadel)
        {
            this.pocetDveri = pocetDveri;
        }

        public override void vypis() => Console.WriteLine("Auto vyrobce {0} jede rychlosti {1} km/h a ma {2} sedadel a {3} dveri", vyrobce, rychlost, pocetSedadel, pocetDveri);
    }

    public class motorka : vozidlo
    {
        int pocetKol;
        public motorka(string vyrobce, int rychlost, int pocetSedadel, int pocetKol) : base(vyrobce, rychlost, pocetSedadel)
        {
            this.pocetKol = pocetKol;
        }

        public override void vypis() => Console.WriteLine("Motorka vyrobce {0} jede rychlosti {1} km/h a ma {2} sedadel a {3} kol", vyrobce, rychlost, pocetSedadel, pocetKol);
    }
}
