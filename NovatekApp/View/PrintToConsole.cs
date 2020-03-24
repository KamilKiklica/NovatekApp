using System;
using System.Collections.Generic;
using System.Globalization;
using NovatekApp.Models;


namespace NovatekApp.View
{
    class PrintToConsole
    {
        public static void ListOfCalculatedNumbersFromDates(int year, List<int> listOfNumbers)
        {
            Console.WriteLine("List of calculated numbers from dates in year {0} ",year+":\n");

            foreach (var number in listOfNumbers)
            {
                Console.Write(number + " ");
            }

        }

        public static void ListOfPrimeNumbers(List<int> listOfPrimeNumbers)
        {
            Console.WriteLine("List of prime numbers from range {0} ", "RANGE" + ":\n");

            foreach (var number in listOfPrimeNumbers)
            {
                Console.Write(number + " ");
            }

        }

        public static void AverageOfTwoNeighbourPrimeNumbers(int firstPrimeNumber, int secondPrimeNumber, double result)
        {
            Console.WriteLine("Average of numbers {0} and {1} = {2}", firstPrimeNumber, secondPrimeNumber, DisplayFiveDecimal(result));
        }


        public static void FileContent(string filename)
        {
            var fileContent = FileReader.ReadFile(filename);
            foreach (var line in fileContent)
            {
                Console.WriteLine(line);
            }
        }

        private static string DisplayFiveDecimal(double dbValue)
        {
            string converted = dbValue.ToString("0.00000", CultureInfo.InvariantCulture);
            return converted;
        }
    }
}
