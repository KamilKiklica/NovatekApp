using System;
using System.Collections.Generic;
using NovatekApp.Services;
using NovatekApp.View;

namespace NovatekApp.Controllers
{
    public class PrimeNumbersController
    {
        private int Start;
        private int Stop;
        private List<int> PrimeNumbers;
        public PrimeNumbersController(int start, int stop)
        {
            Start = start;
            Stop = stop;
        }
        public void GetPrimeNumbersFromRangeOfIntegers()
        {
            PrimeNumbers = PrimeNumbersCalculations.GetPrimeNumbersFromRangeOfIntegers(Start, Stop);
            PrintToConsole.ListOfPrimeNumbers(PrimeNumbers);
        }

        public void GetAverageOfNeighbourPrimeNumbers()
        {
            if (PrimeNumbers.Count < 2)
            {
                Console.WriteLine("Not enough prime numbers on list. You need at least 2 numbers..");
            }
            else
            {
                for (int i = 0; i < PrimeNumbers.Count - 1; i++)
                {
                    int first = PrimeNumbers[i];
                    int second = PrimeNumbers[i + 1];
                    double result = ((double)first + (double)second) /2;
                    PrintToConsole.AverageOfTwoNeighbourPrimeNumbers(first, second, result);
                }
            }
        }
    }
}