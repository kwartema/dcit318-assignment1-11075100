using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the lengths of three sides of a triangle:");

            Console.Write("Side 1: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Side 2: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Side 3: ");
            double c = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Sides must be positive numbers.");
                return;
            }

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Triangle Type: Equilateral");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Triangle Type: Isosceles");
                else
                    Console.WriteLine("Triangle Type: Scalene");
            }
            else
            {
                Console.WriteLine("The provided sides do not form a valid triangle.");
            }
        }
    }
}
