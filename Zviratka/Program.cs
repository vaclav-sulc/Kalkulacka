using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zviratka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dog pes = new dog();
            cat kocka = new cat();
            pes.sound();
            kocka.sound();
        }
    }
}
