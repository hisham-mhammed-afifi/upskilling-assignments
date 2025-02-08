namespace Advanced.VehicleControlSystem
{

    public interface IVehicle
    {
        void Start();
        void Stop();
        void Describe();
    }

    // Step 2: Implement Different Types of Vehicles
    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopping...");
        }

        public void Describe()
        {
            Console.WriteLine("This is a Car, perfect for family trips and daily commuting.");
        }
    }

    public class Truck : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Truck is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Truck is stopping...");
        }

        public void Describe()
        {
            Console.WriteLine("This is a Truck, used for transporting heavy goods.");
        }
    }

    public class Motorcycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Motorcycle is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Motorcycle is stopping...");
        }

        public void Describe()
        {
            Console.WriteLine("This is a Motorcycle, great for quick travel and flexibility.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = new Car();
            car.Start();


            Truck truck = new Truck();
            truck.Start();
            truck.Stop();

            IVehicle[] vehicles =
            {
                new Car(),
                new Truck(),
                new Motorcycle(),
            };

            for (int i = 0; i < vehicles.Length; i++)
            {
                vehicles[i].Describe();
            }
        }
    }
}
