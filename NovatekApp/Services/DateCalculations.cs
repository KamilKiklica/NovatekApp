using System;
using System.Collections.Generic;
using System.Linq;

namespace NovatekApp.Services
{
    public class DateCalculations
    {
        private static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        public static List<int> GetListOfCalculatedNumbers(DateTime StartDate, DateTime EndDate)
        {
            List<int> SumOfDateDigits = new List<int>();
            foreach (DateTime day in EachDay(StartDate, EndDate))
            {
                int dateAsNumber = CalculateDateToNumber(day);
                SumOfDateDigits.Add(dateAsNumber);
            }
            return SumOfDateDigits;
        }

        public static int CalculateDateToNumber(DateTime concreteDate)
        {
            int daySum = concreteDate.Day.ToString().Sum(c => c - '0');
            int monthSum = concreteDate.Month.ToString().Sum(c => c - '0');
            int yearSum = concreteDate.Year.ToString().Sum(c => c - '0');
            int dateAsNumber = (daySum + monthSum + yearSum) * concreteDate.Day;
            return dateAsNumber;
        }
    }


}