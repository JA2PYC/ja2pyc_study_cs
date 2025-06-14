// See https://aka.ms/new-console-template for more information

using System.Globalization;

namespace ControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control Statements");

            // If-Else example
            Console.WriteLine("----------------------");
            Console.WriteLine("If-Else Example");

            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3.");
                Console.WriteLine($"The number is {number}");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            if (number <= 255)
            {
                Console.WriteLine("The number can convert to byte.");
            }
            else if (number <= 65535)
            {
                Console.WriteLine("The number can convert to ushort.");
            }
            else if (number <= 2147483647)
            {
                Console.WriteLine("The number can convert to int.");

            }
            else
            {
                Console.WriteLine("The number can convert to long.");
            }

            // Conditional Operator example
            string result = (number % 2 == 0) ? "Even" : "Odd";

            Console.WriteLine($"The number is {result}.");


            // Switch example
            Console.WriteLine("----------------------");
            Console.WriteLine("Switch Statement Example");

            string day = "Monday";
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's the start of the week.");
                    break;
                case "Friday":
                    Console.WriteLine("It's almost the weekend!");
                    break;
                default:
                    Console.WriteLine("It's just another day.");
                    break;
            }

            DateTime dateTime = DateTime.Now;
            DayOfWeek dayOfWeek = dateTime.DayOfWeek;

            Console.WriteLine($"Today is {dayOfWeek}.");

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine(dateTime.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US")) + " is a Monday. the start of the week.");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine(dateTime.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US")) + " is a Tuesday.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine(dateTime.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US")) + " is a Wednesday.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine(dateTime.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US")) + " is a Thursday.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine(dateTime.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US")) + " is a Friday. the end of the work week.");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine(dateTime.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US")) + " is a Saturday. the weekend!");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine(dateTime.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US")) + " is a Sunday. the end of the weekend.");
                    break;
                default:
                    Console.WriteLine("Unknown day of the week.");
                    break;
            }

            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}