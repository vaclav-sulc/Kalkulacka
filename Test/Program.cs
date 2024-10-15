using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicilizace listu
            List<Product> Products = new List<Product>();
            int numberOfProducts;

            // Pocet Produktů
            Console.WriteLine("Zadejte pocet produktu:");
            numberOfProducts = int.Parse(Console.ReadLine());

            // Zapsani studentu
            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine("Zadejte jmeno " + (i + 1) + ". produktu a jeho cenu:");
                Products.Add(new Product() { name = Console.ReadLine(), price = float.Parse(Console.ReadLine()), category = Console.ReadLine() });
            }

            // Seradit list podle kategorii
            Products = Products.OrderBy(Product => Product.category).ToList(); // Lambda expressions jsou GOOOOOOOOAAATEEEEDDDDD, JAVA je lepsi nez C# lowkey
            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine((i+1) + ". " + Products[i].name + " - " + Products[i].category + " - " + Products[i].price + "Kc");
            }

            AveragePrice(Products);
            MostExpensive(Products);
            AboveAverage(Products);
        }

        // průměr cen a odchylka od průměru
        public static void AveragePrice(List<Product> Products)
        {
            float average = 0;
            float averageDelta = 0;
            foreach (Product product in Products)
            {
                average += product.price;
            }
            average /= Products.Count;
            foreach (Product product in Products)
            {
                float tmp = product.price - average;
                if (tmp < 0)
                {
                    tmp *= -1;
                }
                averageDelta += tmp;
            }

            averageDelta /= Products.Count;
            Console.WriteLine("Prumerna cena produktu je: " + average + "Kc");
            Console.WriteLine("Prumerna odchylka je: " + averageDelta + "Kc");
        }

        // nejdražší produkt
        public static void MostExpensive(List<Product> Products)
        {
            float mostExpensive = 0;
            string mostExpensiveName = "";
            foreach (Product product in Products)
            {
                if (product.price > mostExpensive)
                {
                    mostExpensive = product.price;
                    mostExpensiveName = product.name;
                }
            }

            Console.WriteLine("Nejdrazsi produkt je: " + mostExpensiveName + " za " + mostExpensive + "Kc");
        }

        // výpis počtu produktů dražších než průměr
        public static void AboveAverage(List<Product> Products)
        {
            float average = 0;
            float aboveAverage = 0;
            foreach (Product product in Products)
            {
                average += product.price;
            }
            average /= Products.Count;
            foreach (Product product in Products)
            {
                if (product.price > average)
                {
                    aboveAverage++;
                }
            }
            Console.WriteLine("Pocet produktu drahsich nez prumer je: " + aboveAverage);
        }

    }
    
    public class Product
    {
        public string name;
        public string category;
        public float price;
    }

    // Dneska se mam dobre, tohle je moc ezzzzzzzz
}
