using System;
using System.Collections.Generic;
using System.IO;

namespace NovatekApp.Models
{
    class FileReader
    {
        public static List<string> ReadFile(String filename)
        {
            List<string> fileContent = new List<string>();
            try
            {
                foreach (string line in File.ReadAllLines(
                    @"..\..\..\Resources\" + filename))
                {
                    fileContent.Add(line);
                }
                return fileContent;
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return fileContent;
        }
    }
}
