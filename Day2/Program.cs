namespace Day2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose an assignment to run:");
            Console.WriteLine("1: Find the largest number among three numbers");
            Console.WriteLine("2: Grade mapping");
            Console.WriteLine("3: Sum of numbers exceeding 100");
            Console.WriteLine("4: Multiplication table");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FindLargestNumber();
                    break;
                case 2:
                    GradeMapping();
                    break;
                case 3:
                    SumNumbers();
                    break;
                case 4:
                    MultiplicationTable();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
                    break;
            }
        }

        static void FindLargestNumber()
        {
            Console.WriteLine("Enter three numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int largest = num1;

            if (num2 > largest)
                largest = num2;
            if (num3 > largest)
                largest = num3;

            Console.WriteLine("Largest is: " + largest);
        }

        static void GradeMapping()
        {
            Console.WriteLine("Enter a grade (A, B, C, D, E):");
            char grade = char.ToUpper(Console.ReadLine()[0]);

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Fair");
                    break;
                case 'E':
                    Console.WriteLine("Failed");
                    break;
                default:
                    Console.WriteLine("No match");
                    break;
            }
        }

        static void SumNumbers()
        {
            int sum = 0;

            Console.WriteLine("Enter numbers to sum (type 'stop' to end):");

            while (sum <= 100)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (sum > 100)
                {
                    Console.WriteLine("Your sum (" + sum + ") exceeds 100 now.");
                    break;
                }
            }
        }

        static void MultiplicationTable()
        {
            Console.WriteLine("Enter a number between 2 and 9:");
            int number = int.Parse(Console.ReadLine());

            if (number >= 2 && number <= 9)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} * {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number between 2 and 9.");
            }
        }
    }
}
