using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();

            double result = double.MinValue();

            while (command != "End")
            {
                if (command == "add")
                {

                }
                else if (command == "subtract")
                {

                }
                else if (command == "divide")
                {
                    Console.WriteLine("Enter a number: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a number: ");
                    double num2 = double.Parse(Console.ReadLine());
                }
                else if (command == "power")
                {

                }
                else if (command == "multiply")
                {

                }
                else
                {
                    Console.WriteLine("Invalid command");
                }

                if(result != double.MinValue)
                {
                    Console.WriteLine($"Result: {result}");

                }
                command = Console.ReadLine().ToLower();
            }
            static double Add(double num1, double num2)
            {

            }
            static double Subtract(double num1, double num2)
            {

            }
            static double Divide(double num1, double num2)
            {
                return num1 / num2;
            }
            static double Power(double num1, double num2)
            {

            }
        }
    }
}
