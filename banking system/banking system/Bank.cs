using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace banking_system
{
    public class Bank
    {
        private List<Account> Accounts;

        public Bank()
        {
            Accounts = new List<Account>();
        }

        public void createAccount(int accountNumber, int pin)
        {
            if (FindAccount(accountNumber) == null)
            {
                Account newAccount = new Account(accountNumber, pin);
                Accounts.Add(newAccount);
                Console.WriteLine($"Account created successfully. Account Number: {accountNumber}");
            }
            else
            {
                Console.WriteLine("Account with this number already exists.");
            }
        }

        public Account login(int accountNumber, int pin)
        {
            Account account = FindAccount(accountNumber);
            if (account != null && account.pin == pin)
            {
                Console.WriteLine("Login successful.");
                return account;
            }
            else
            {
                Console.WriteLine("Invalid account number or PIN.");
                return null;
            }
        }

        private Account FindAccount(int accountNumber)
        {
            foreach (Account account in Accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return account;
                }
            }
            return null;
        }
    }
}
