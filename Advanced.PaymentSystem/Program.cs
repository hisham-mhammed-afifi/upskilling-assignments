namespace Advanced.PaymentSystem
{

    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }


    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}...");
        }
    }

    public class BankTransfer : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing bank transfer of ${amount}...");
        }
    }

    public class PayPal : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}...");
        }
    }

    public class PaymentProcessor
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Payment Method: 1- Credit Card, 2- Bank Transfer, 3- PayPal");
            string choice = Console.ReadLine();

            IPaymentMethod paymentMethod;
            switch (choice)
            {
                case "1":
                    paymentMethod = new CreditCardPayment();
                    break;
                case "2":
                    paymentMethod = new BankTransfer();
                    break;
                case "3":
                    paymentMethod = new PayPal();
                    break;

                default:
                    throw new ArgumentException("Invalid payment method selected!");
            }


            Console.WriteLine("Enter payment amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            PaymentProcessor processor = new PaymentProcessor(paymentMethod);
            processor.ProcessPayment(amount);
        }
    }
}
