using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zviratka
{
    public abstract class animal
    {
        abstract public void sound();
    }

    public class cat : animal
    {
        public override void sound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class dog : animal
    {
        public override void sound()
        {
            Console.WriteLine("Haf");
        }
    }
}
