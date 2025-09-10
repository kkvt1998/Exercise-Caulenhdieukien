using System;

namespace CheckLeapYear
{
       class Program
    {
        static void Main(string[] args)
        {
            // Input year from user
            int year;
            Console.WriteLine("Program: Check Leap Year ");
            Console.Write("Please enter a year: ");
            year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + year);
            // Check if the year is a leap year
            if (((year % 4 == 0) && (year % 100 != 0))||(year % 400 == 0)){
                Console.WriteLine(year + " is a leap year.");
            }
            else
            { 
                Console.WriteLine(year + " is not a leap year.");
            }
            Console.ReadLine();
        }
    }
}