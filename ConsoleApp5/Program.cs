using System;

public class BankAccount
{
    private decimal balance;

    // Initializing the bank account with a starting balance
    public BankAccount(decimal initialBalance) => balance = initialBalance;

    // Method to deposit money
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive");
        }
    }

    // Method to withdraw money, returns true if successful, false if not.
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal must be positive.");
            return false;
        }
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdaw: {amount}. New balance: {balance}");
            return true;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
            return false;
        }
    }

    // Method to get the current balance.
    public decimal GetBalance() => balance;
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new BankAccount object with an initial balance of 1000
        BankAccount myAccount = new BankAccount(1000);

        // Deposit 500 into the account
        myAccount.Deposit(500);

        // Attempt to withdraw 200 and display the result
        if (myAccount.Withdraw(200))
        {
            Console.WriteLine($"Withdrawal successful. Current Balance: ${myAccount.GetBalance()}");
        }
        else
        {
            Console.WriteLine("Withdrawal failed.");
        }
    }
}