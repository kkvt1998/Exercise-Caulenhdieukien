using System;

namespace LinearEquationResolver
{
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolve");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
            float a, b;
            Console.Write("Enter value a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Enter value b = ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("The equation is: " + a + "x + " + b + " = 0");

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("The equation has infinitely many solutions x!");
                }
                else
                {
                    Console.WriteLine("The equation has no solution!");
                }
            }
            else
            {
                float x = -b / a;
                Console.WriteLine("The equation has a unique solution is x = " + x);
            }
                Console.ReadLine();
        }
    }
}