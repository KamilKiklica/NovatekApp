using System;
using System.Collections.Generic;
using System.Linq;

namespace NovatekApp.Services
{
    public class PrimeNumbersCalculations
    {
        public static List<int> GetPrimeNumbersFromRangeOfIntegers(int start, int stop)
        {
            int[] values = Enumerable.Range(start, stop - start).ToArray();
            List<int> listOfPrimeNumbers = new List<int>();

            foreach (var number in values)
            {
                if (IsPrime(number))
                {
                    listOfPrimeNumbers.Add(number);
                }
            }
            listOfPrimeNumbers = listOfPrimeNumbers.OrderByDescending(a => a).Select(a => a).ToList();
            return listOfPrimeNumbers;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}