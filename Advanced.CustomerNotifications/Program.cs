namespace Advanced.CustomerNotifications
{

    public interface INotification
    {
        void Send(string recipient, string message);
    }


    public class EmailNotification : INotification
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Sending Email to {recipient}: {message}");
        }
    }

    public class SMSNotification : INotification
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }

    public class PushNotification : INotification
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
        }
    }


    public class NotificationService
    {
        private readonly INotification _notification;

        public NotificationService(INotification notification)
        {
            _notification = notification;
        }

        public void NotifyCustomer(string recipient, string message)
        {
            _notification.Send(recipient, message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Notification Type: 1- Email, 2- SMS, 3- Push Notification");
            string choice = Console.ReadLine();

            INotification notificationMethod;
            switch (choice)
            {
                case "1":
                    notificationMethod = new EmailNotification();
                    break;
                case "2":
                    notificationMethod = new SMSNotification();
                    break;
                case "3":
                    notificationMethod = new PushNotification();
                    break;

                default:
                    throw new ArgumentException("Invalid notification type selected!");
            }


            Console.WriteLine("Enter recipient: ");
            string recipient = Console.ReadLine();

            Console.WriteLine("Enter message: ");
            string message = Console.ReadLine();

            NotificationService notificationService = new NotificationService(notificationMethod);
            notificationService.NotifyCustomer(recipient, message);

            Console.WriteLine("Notification sent successfully!");
        }
    }
}
