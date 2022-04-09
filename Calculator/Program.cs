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

            }
             static double Multiply(double num1, double num2)
            {

            }
        }
    }
}
