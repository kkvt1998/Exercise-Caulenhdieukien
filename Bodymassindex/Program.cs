using System;

namespace Bodymassindex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program: Calculate Body Mass Index (BMI)");
            Console.WriteLine("Enter weight and height to calculate BMI.");
            float weight, height, bmi;
            Console.Write("Enter your weight in kilograms: ");
            weight = float.Parse(Console.ReadLine());
            Console.Write("Enter your height in metre: ");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Your weight is: " + weight + " kg");
            Console.WriteLine("Your height is: " + height + " m");
            //Calculate BMI
            bmi = weight / (height * height);
            Console.WriteLine("BMI is: " + bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("You are Underweight.");
            }
            else if ( 18.5 <= bmi && bmi < 25.0)
            {
               Console.WriteLine("You are Normal. ");
            }
            else if (25.0 <= bmi && bmi < 30.0)
            {
                Console.WriteLine("You are Overweight. ");
            }
            else
            {
                Console.WriteLine("You are Obese. ");
            }

                Console.ReadLine();
        }
    }
}