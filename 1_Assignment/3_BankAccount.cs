using System;


class BankAccount
{
    public string AccountNumber;
    public string AccountHolderName;
    private double Balance;

    public BankAccount(string accNo, string holderName, double initialBalance)
    {
        AccountNumber = accNo;
        AccountHolderName = holderName;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount should be more than 0.");
            return;
        }
        Balance = Balance + amount;
        Console.WriteLine("Rs." + amount + " deposited successfully.");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Please enter valid amount.");
            return;
        }
        if (amount > Balance)
        {
            Console.WriteLine("Sorry, not enough balance in account.");
            return;
        }
        Balance = Balance - amount;
        Console.WriteLine("Rs." + amount + " withdrawn.");
    }

    public void ShowBalance()
    {
        Console.WriteLine("Account Holder : " + AccountHolderName);
        Console.WriteLine("Account Number : " + AccountNumber);
        Console.WriteLine("Current Balance: Rs." + Balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount("SBI12345", "Ankit Kumar", 10000);

        Console.WriteLine("=== Bank Account Operations ===\n");

        acc.ShowBalance();
        Console.WriteLine();

        acc.Deposit(5000);
        acc.ShowBalance();
        Console.WriteLine();

        acc.Withdraw(3000);
        acc.ShowBalance();
        Console.WriteLine();

        acc.Withdraw(50000);
        Console.WriteLine();

        acc.Deposit(-200);
    }
}
