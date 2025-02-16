namespace Advanced.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 9, 1, 7 };

            Console.WriteLine("Original Array: " + string.Join(", ", numbers));
            ArrayUtils.ReverseArray(numbers);
            Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));

            int maxNumber = ArrayUtils.FindMax(numbers);
            Console.WriteLine("Maximum Value: " + maxNumber);

            string[] words = { "Apple", "Banana", "Mango", "Peach" };
            Console.WriteLine("\nOriginal Array: " + string.Join(", ", words));
            ArrayUtils.ReverseArray(words);
            Console.WriteLine("Reversed Array: " + string.Join(", ", words));

            string maxWord = ArrayUtils.FindMax(words);
            Console.WriteLine("Maximum String: " + maxWord);

            Console.WriteLine("\n=======================================================\n");

            Cache<int, string> cache = new Cache<int, string>(3);

            cache.Add(1, "One");
            cache.Add(2, "Two");
            cache.Add(3, "Three");
            cache.DisplayCache();

            Console.WriteLine("Get Key 1: " + cache.Get(1));
            cache.DisplayCache();

            cache.Add(4, "Four");
            cache.DisplayCache();

            try
            {
                Console.WriteLine("Get Key 2: " + cache.Get(2));
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
