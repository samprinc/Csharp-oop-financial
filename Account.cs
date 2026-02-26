using System;
using System.Collections.Generic;

namespace PataSpaceAcademy
{
    using System;

// --- THE BLUEPRINT ---
// A Class is a template. Here, we define what an "Account" is and what it can do.
class Account
{
    // 1. PROPERTIES (The Data)
    // These hold the information for each specific account.
    public string AccountName { get; set; } // The name of the account owner
    public double Balance { get; set; }     // The current amount of money

    // 2. CONSTRUCTOR (The Setup)
    // This runs automatically exactly ONCE when a new Account is created.
    public Account(string accountName)
    {
        AccountName = accountName; // Set the name provided by the user
        Balance = 0;               // Every new account starts with 0 KES
    }

    // 3. METHODS (The Actions)
    // These are the behaviors or functions the account can perform.

    // Method to handle putting money IN
    public void Deposit(double amount)
    {
        // Security logic: You can't deposit a negative amount
        if (amount > 0)
        {
            Balance += amount; // Add the amount to the current balance
            Console.WriteLine($"Deposited: {amount} KES. New Balance: {Balance} KES");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to handle taking money OUT
    public void Withdraw(double amount)
    {
        // Security logic: Amount must be positive AND you can't withdraw more than you have
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount; // Subtract the amount from the current balance
            Console.WriteLine($"Withdrew: {amount} KES. New Balance: {Balance} KES");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }
}


}