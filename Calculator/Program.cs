using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command =  Console.ReadLine();
            int result = int.MinValue;
            while (command != "End")
            {
                switch (command)
                {
                    case "Multiply":
                        {
                            Console.WriteLine("Enter a number: ");

                            int number1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter a second number: ");

                            int number2 = int.Parse(Console.ReadLine());

                            result = Multiply(number1, number2);
                        }
                        break;
                    case "End":
                        break;
                        default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
                if (result != int.MinValue)
                {
                    Console.WriteLine($"Result: {result} ");
                }
                command = Console.ReadLine();
            }
        }

        private static int Multiply(int number1, int number2)
        {
         return number1 * number2;
        }
        
            
        }
    }

