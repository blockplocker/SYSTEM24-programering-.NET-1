using System;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace banking_system
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Account account = new Account(1, 1);

            account.Deposit(200);
            Console.WriteLine($"Balance after deposit: {account.GetBalance()} kr");

            if (account.Withdraw(50))
            {
                Console.WriteLine($"Withdrawal successful!");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }

            Console.WriteLine($"Balance: {account.GetBalance()} kr");

            account.PrintTransactions();






            Console.WriteLine("Welcome to block bank");
            Console.WriteLine("create account[c] loggin[l] ");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case 'c':
                    Console.WriteLine("Account nummber:");
                    Console.WriteLine("pin:");
                    break;

                case 'l':
                    Console.WriteLine("Account nummber:");
                    Console.WriteLine("pin:");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }



        }
    }
}
