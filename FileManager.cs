using System;
using System.Collections.Generic;
using System.IO;
//I had to get help doing the file manager again but this was the example I found.
namespace ApostlesApp
{
    class FileManager
    {
        private string filePath;

        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public void WriteApostlesToFile(List<Apostle> apostles)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var apostle in apostles)
                {
                    writer.WriteLine($"{apostle.Seniority},{apostle.Name}");
                }
            }
        }

        public List<Apostle> ReadApostlesFromFile()
        {
            List<Apostle> apostles = new List<Apostle>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                //null just in case
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int seniority))
                    {
                        apostles.Add(new Apostle(parts[1], seniority));
                    }
                    else
                    {
                        Console.WriteLine("Invalid line format: " + line);
                    }
                }
            }
            return apostles;
        }
    }
}
