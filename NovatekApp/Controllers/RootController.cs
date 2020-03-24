using System;
using NovatekApp.View;

namespace NovatekApp.Controllers
{
    public class RootController
    {
        private int Year;
        private DateController ControllerOfDate;
        private PrimeNumbersController ControllerOfPrimeNumbers;
        public RootController()
        {
            Year = 2020;
            ControllerOfDate = new DateController(Year);
            ControllerOfPrimeNumbers = null;
        }

        public void run()
        {
            var controllerOfDate = this.ControllerOfDate;
            bool running = true;
            int input;

            while (running)
            {
                Console.Clear();
                ShowMenu("Menu.txt");
                input = getIntegerInput();

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        controllerOfDate.ShowListOfNumbers();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Please input start (included) range integer.");
                        int start = getIntegerInput();
                        Console.WriteLine("Please input end (excluded) range integer.");
                        int stop = getIntegerInput();
                        if (start > stop)
                        {
                            Console.WriteLine("Wrong input data. Start integer should be < than end integer");
                        }
                        else
                        {
                            ControllerOfPrimeNumbers = new PrimeNumbersController(start, stop);
                            ControllerOfPrimeNumbers.GetPrimeNumbersFromRangeOfIntegers();
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        if (ControllerOfPrimeNumbers == null)
                        {
                            Console.WriteLine("Please use option 2 first...");
                        }
                        else
                        { 
                            ControllerOfPrimeNumbers.GetAverageOfNeighbourPrimeNumbers();
                        }
                        Console.ReadLine();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Choose correct number... Press ENTER");
                        Console.ReadLine();
                        break;

                }
            }
        }

        public void ShowMenu(string filename)
        {
            PrintToConsole.FileContent(filename);
        }

        public int getIntegerInput()
        {
            bool inputIsValid = false;
            int number;
            while (!inputIsValid)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out number)){
                    inputIsValid = true;
                    return Convert.ToInt32(input);
                }
                Console.WriteLine("Please input an integer.");
            }
            return 0;
        }
    }
}