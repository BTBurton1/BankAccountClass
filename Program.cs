using BankApp;
public class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount("Bilal Burton", 500);

        // Show initial info
        Console.WriteLine("Initial Bank Info:\n");
        account.DisplayAccountInfo();

        // testing deposit
        account.Deposit(200);   
        account.Deposit(-50);   // Attempting to deposit negative money

        // testing withdraw
        account.Withdraw(100);  
        account.Withdraw(700);  // Attempting to withdraw too much money

        // Show final info
        Console.WriteLine("\nFinal Bank Info: ");
        account.DisplayAccountInfo();

        Console.WriteLine("\nTransaction History:");
        foreach (string t in account.Transactions)
        {
            Console.WriteLine(t);
        }
    }
}
