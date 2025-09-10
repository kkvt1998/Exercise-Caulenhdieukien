using System;

namespace Numberofdayinmonth
{
    class Program
    {
        static void Main(string[] args)
        {
            // input a month in year
            Console.WriteLine("Program: Calculate the number of days in a month");
            Console.Write("Enter a month number (1-12): ");
            int month;
            month = Int32.Parse(Console.ReadLine());
            // Calculate the number of days in a month
            switch (month) {
                case 2:
                    Console.WriteLine("Number of days: 28 or 29 days");
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Number of days: 31 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Number of days: 30 days");
                    break;
                default:
                    Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
                    break;
            }
            Console.ReadLine();
        }
    }
}