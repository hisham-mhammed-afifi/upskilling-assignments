namespace Advanced.Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123456789", "John Doe", 500);
            Console.WriteLine($"Account Holder: {account.AccountHolderName}");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Initial Balance: {account.Balance:C}\n");

            account.Deposit(200);
            account.Withdraw(100);
            account.Withdraw(700); // Should print insufficient funds

            Console.WriteLine("=============================================\n");

            Product product = new Product("Laptop", 1500.99m, 10);
            Console.WriteLine($"Product: {product.Name}");
            Console.WriteLine($"Price: {product.Price:C}");
            Console.WriteLine($"Stock Available: {product.StockQuantity}");
            Console.WriteLine($"Is Available: {product.IsAvailable}\n");

            product.UpdateStock(5);
            product.UpdateStock(-12); // Should print an error

            Console.WriteLine("=============================================\n");

            Car car = new Car("Toyota", "Camry", 2015, 50000);
            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");
            Console.WriteLine($"Mileage: {car.Mileage}");
            Console.WriteLine($"Age: {car.Age} years\n");

            car.Drive(150);
        }
    }
}
