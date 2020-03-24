using System;
using System.Collections.Generic;
using NovatekApp.Services;
using NovatekApp.View;

namespace NovatekApp.Controllers
{
    class DateController
    {
        private int Year;
        private DateTime Start;
        private DateTime Stop;

        public DateController(int year)
        {
            Year = year;
            Start = new DateTime(year, 1, 1);
            Stop = new DateTime(year, 12, 31);
        }


        public void ShowListOfNumbers()
        {
            List<int> listOfNumbers = DateCalculations.GetListOfCalculatedNumbers(Start, Stop);
            PrintToConsole.ListOfCalculatedNumbersFromDates(Year, listOfNumbers);
        }
    }
}
