using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Properties
{
    internal class Product
    {
        private string _name;
        private decimal _price;
        private int _stockQuantity;

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
                _price = value;
            }
        }

        public int StockQuantity
        {
            get { return _stockQuantity; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Stock quantity cannot be negative.");
                }
                _stockQuantity = value;
            }
        }

        public bool IsAvailable
        {
            get { return _stockQuantity > 0; }
        }

        public Product(string name, decimal price, int stockQuantity)
        {
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public void UpdateStock(int quantity)
        {
            if (StockQuantity + quantity < 0)
            {
                throw new ArgumentException("Insufficient stock to reduce.");
            }

            StockQuantity += quantity;
            Console.WriteLine($"Stock updated. New stock quantity: {StockQuantity}");
        }
    }
}
