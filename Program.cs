using System;
using System.Collections.Generic;

namespace ApostlesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup File here
            string filePath = "apostles.txt";
            FileManager fileManager = new FileManager(filePath);

            // Apostle list here (I used the original ones)
            List<Apostle> apostles = new List<Apostle>
            {
                new Apostle("Peter", 1),
                new Apostle("James", 2),
                new Apostle("John", 3),
                new Apostle("Andrew", 4),
                new Apostle("Philip", 5),
                new Apostle("Bartholomew", 6),
                new Apostle("Matthew", 7),
                new Apostle("Thomas", 8),
                new Apostle("James (son of Alphaeus)", 9),
                new Apostle("Simon", 10),
                new Apostle("Jude", 11),
                new Apostle("Judas Iscariot", 12)
            };

            // Write apostles to file
            fileManager.WriteApostlesToFile(apostles);

            // Read apostles from same file
            List<Apostle> apostlesFromFile = fileManager.ReadApostlesFromFile();
            
            // apostles by seniority
            Console.WriteLine("Apostles by Seniority:");
            ApostlesBySeniority senioritySorter = new ApostlesBySeniority(apostlesFromFile);
            senioritySorter.Display();

            // and by alphabetical order
            Console.WriteLine("\nApostles by Alphabetical Order:");
            ApostlesByAlphabeticalOrder alphabeticalSorter = new ApostlesByAlphabeticalOrder(apostlesFromFile);
            alphabeticalSorter.Display();
        }
    }
}
