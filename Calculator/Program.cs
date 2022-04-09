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
                        int number1 = int.Parse(Console.ReadLine());
                        int number2 = int.Parse(Console.ReadLine());

                        result = Multiply(number1, number2);
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
            throw new NotImplementedException();
        }
    }
}
