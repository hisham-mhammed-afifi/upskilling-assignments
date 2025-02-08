using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Properties
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; private set; }

        public Car(string make, string model, int year, int mileage = 0)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        public void Drive(int distance)
        {
            if (distance < 0)
            {
                throw new ArgumentException("Distance cannot be negative.");
            }

            Mileage += distance;
            Console.WriteLine($"Driven {distance} miles. Total mileage: {Mileage} miles.");
        }

        public int Age
        {
            get { return DateTime.Now.Year - Year; }
        }
    }
}
