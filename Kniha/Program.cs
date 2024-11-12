using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniha
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Kniha
    {
        private string nazevKnihy;
        private string autor;
        private int cena;
        public Kniha(string nazevKnihy, string autor, int cena)
        {
            this.nazevKnihy = nazevKnihy;
            this.autor = autor;
            this.cena = cena;
        }

        public string NazevKnihy
        {
            get { return nazevKnihy; }
            set { nazevKnihy = value; }
        }
        public string Autor
            {
            get { return autor; }
            set { autor = value; }
        }

        public int Cena
        {
            get { return cena; }
            set { if (value < 0)
                {
                    Console.WriteLine("Cena nemůže být záporná");
                }
                else
                {
                    cena = value;
                }
            }
        }


    }
}
