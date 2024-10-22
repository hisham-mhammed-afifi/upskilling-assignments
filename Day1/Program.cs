using System;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Simple Greeting Program");
                Console.WriteLine("2. Basic Arithmetic Operations");
                Console.WriteLine("3. Age Calculator");
                Console.WriteLine("4. Temperature Converter");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SimpleGreeting();
                        break;
                    case "2":
                        BasicArithmeticOperations();
                        break;
                    case "3":
                        AgeCalculator();
                        break;
                    case "4":
                        TemperatureConverter();
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Thank you for using the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }

        //  Assignment 1: Simple Greeting Program
        static void SimpleGreeting()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to the C# course.");
        }

        //  Assignment 2: Basic Arithmetic Operations
        static void BasicArithmeticOperations()
        {
            try
            {
                Console.Write("Enter the first number: ");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                double sum = number1 + number2;
                double difference = number1 - number2;
                double product = number1 * number2;
                double quotient = number2 != 0 ? number1 / number2 : double.NaN;

                Console.WriteLine($"\nSum: {sum}");
                Console.WriteLine($"Difference: {difference}");
                Console.WriteLine($"Product: {product}");
                if (number2 != 0)
                    Console.WriteLine($"Quotient: {quotient}");
                else
                    Console.WriteLine("Quotient: Undefined (division by zero)");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
        }

        //  Assignment 3: Age Calculator
        static void AgeCalculator()
        {
            try
            {
                Console.Write("Enter your birth year: ");
                int birthYear = Convert.ToInt32(Console.ReadLine());

                int currentYear = DateTime.Now.Year;
                if (birthYear > currentYear)
                {
                    Console.WriteLine("Birth year cannot be in the future.");
                    return;
                }

                int age = currentYear - birthYear;

                Console.WriteLine($"You are {age} years old.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
            }
        }

        //  Assignment 4: Temperature Converter
        static void TemperatureConverter()
        {
            try
            {
                Console.Write("Enter the temperature in Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());

                double fahrenheit = celsius * (9.0 / 5.0) + 32;

                Console.WriteLine($"{celsius} degrees Celsius is {fahrenheit} degrees Fahrenheit.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid temperature.");
            }
        }
    }
}
