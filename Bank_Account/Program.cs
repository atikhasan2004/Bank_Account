using System;
class Bank
{
    public double Acc_num;
    public string Acc_holder;
    public double Balance;
    public Bank(double n, string h, double B)
    {
        Acc_num = n;
        Acc_holder = h;
        Balance = B;
    }
    public void deposit(double amount)
    {
        if (Balance > amount)
        {
            Balance += amount;
            Console.WriteLine($"\nDeposit after balance= {Balance}");
        }
        else
        {
            Console.WriteLine("\nDeposit must be greater than 0.");
        }
    }
    public void withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"\nWithdraw after total balance= {Balance}");
        }
        else
        {
            Console.WriteLine("You can't withdraw money.");
        }
    }
    public void displayInfo()
    {
        Console.WriteLine($"\nAccount number: {Acc_num}, Account holder: {Acc_holder}, Balance: {Balance}\n");
    }
}
class Program
{
    static void Main(string [] args)
    {
        Bank myBank = new Bank(2243081122, "ATIK HASAN", 2000);
        myBank.deposit(1200);
        myBank.withdraw(2500);
        myBank.displayInfo();
        Console.WriteLine(("--------------------------"));
        Bank myBank1 = new Bank(11225021, "SALMAN FARSHI", 5000);
        myBank1.deposit(3000);
        myBank1.withdraw(8000);
        myBank1.displayInfo();
    }
}