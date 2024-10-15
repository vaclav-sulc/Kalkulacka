/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Studenti
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            int numberOfStudents;
            float average = 0;
            int didNotPass = 0;
            float bestScore = 0;
            string bestScoreName = "";

            //POCET STUDENTU
            Console.WriteLine("Zadejte pocet studentu:");
            numberOfStudents = int.Parse(Console.ReadLine());

            //ZAPSANI STUDENTU
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Zadejte jmeno " + (i + 1) + ". studenta a jeho vysledek:");
                students.Add(new Student() { name = Console.ReadLine(), score = float.Parse(Console.ReadLine()) });
            }

            //VYPSANI STATISTIK
            Console.WriteLine("\n--- Statistiky ---");

            foreach (Student student in students)
            {
                Console.WriteLine(student.name + ": " + student.score + "%");

                average += student.score;

                //PROSEL?
                if (student.score < 50)
                {
                    didNotPass++;
                }

                //NEJLEPSI STUDENT
                if (student.score > bestScore)
                {
                    bestScore = student.score;
                    bestScoreName = student.name;
                }
            }

            average /= numberOfStudents;

            Console.WriteLine("\nPrumerny vysledek: " + average + "%");
            Console.WriteLine("Nejlepsi vysledek: " + bestScore + "%" + " (" + bestScoreName + ")");
            Console.WriteLine("Neproslo studentu: " + didNotPass);
        }
    }

    public class Student
{
    public string name;
    public float score;
}
}
*/
