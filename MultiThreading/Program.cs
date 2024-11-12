using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;


namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start measuring time
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Absolute path to the file
            string filePath = @"D:\Users\sulcvac\source\repos\Kalkulacka\MultiThreading\Resources\20k.txt";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the file (each word is on a new line)
                string[] words = File.ReadAllLines(filePath);
                // make a new thread that will print all the words
                

                // Calculate the total length of all words
                int totalLength = words.Sum(word => word.Length);

                // Calculate the average length of words
                double averageLength = (double)totalLength / words.Length;

                Thread thread = new Thread(() =>
                {
                    foreach (string word in words)
                    {
                        Console.WriteLine(word);
                    }
                });

                thread.Start();
                thread.Join();

                // Stop measuring time
                stopwatch.Stop();

                // Output the average length and the time taken
                Console.WriteLine($"Average word length: {averageLength}");
                Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
            }
            else
            {
                // File not found
                Console.WriteLine($"The file at {filePath} was not found.");
            }
        }
    }
}
