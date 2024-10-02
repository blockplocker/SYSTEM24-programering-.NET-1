using System;

public class Account
{
    private int accountNumber;
    private int pin;
    private double balance;
    private new List<string> transactions;

    public Account(int accountNumber, int pin)
    {
        this.accountNumber = accountNumber;
        this.pin = pin;
        this.balance = 0.0;  
        this.transactions = new List<string>();  
    }

    public void Deposit(double amount)
    {
        this.balance += amount;
        transactions.Add($"Deposited: {amount} kr");
    }

    public bool Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            transactions.Add($"Withdrew: {amount} kr");
            return true;
        }
        else
        {
            return false;
        }
    }

    public double GetBalance()
    {
        return balance;
    }

    public void PrintTransactions()
    {
        foreach (string transaction in transactions)
        {
            Console.WriteLine(transaction);
        }
    }


}
