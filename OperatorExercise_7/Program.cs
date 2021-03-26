using System;

namespace OperatorExercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any two numbers.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            DivisionRemainder(a, b);
            AreaOfCircle(a);
        }

        static void DivisionRemainder(int a, int b)
        {
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is equal to {quotient} and has a remainder of {remainder}");
        }

        static double AreaOfCircle(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            return area;
            Console.WriteLine($"The Area of your circle is {area}.");
        }
    }
}
