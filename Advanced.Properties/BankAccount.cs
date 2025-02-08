using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Properties
{
    internal class BankAccount
    {
        private string _accountNumber;
        private string _accountHolderName;
        private decimal _balance;

        // Properties
        public string AccountNumber
        {
            get { return _accountNumber; }
        }

        public string AccountHolderName
        {
            get { return _accountHolderName; }
            set { _accountHolderName = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        public BankAccount(string accountNumber, string accountHolderName, decimal initialBalance = 0)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }

            _accountNumber = accountNumber;
            _accountHolderName = accountHolderName;
            _balance = initialBalance;
        }


        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }

            _balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New Balance: {_balance:C}");
        }


        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return false;
            }

            if (amount > _balance)
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }

            _balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}. Remaining Balance: {_balance:C}");
            return true;
        }
    }
}
