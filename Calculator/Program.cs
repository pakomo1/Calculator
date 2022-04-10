using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();

            int result = int.MinValue();

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

                }
                else if (command == "power")
                {
                    Console.WriteLine("Enter a number: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter another number: ");
                    double num2 = double.Parse(Console.ReadLine());                
                }
                else if (command == "multiply")
                {

                }
                else
                {
                    Console.WriteLine("Invalid command");
                }

                if(result != int.MinValue)
                {
                    Console.WriteLine($"Result: {}");
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

            }
            static double Power(double num1, double num2)
            {
                return Math.Pow(num1, num2);
            }
             static double Multiply(double num1, double num2)
            {

            }
        }
    }
}
