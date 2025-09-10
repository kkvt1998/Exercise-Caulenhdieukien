using System;

namespace ReadNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program: Read Number");
            Console.Write("Enter a number: ");
            int num;
            num = Int32.Parse(Console.ReadLine());

        }
    }
}