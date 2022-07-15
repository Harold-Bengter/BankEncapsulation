using BankEncapsulation;

var bankAccount = new BankAcc();

Console.WriteLine($"Welcome to Bengter Bank, your acc balance is ${bankAccount.Getbalance()}");

Console.WriteLine("Please select from the list: Withdraw or Deposit");
var answer = Console.ReadLine();
if (answer == "Withdraw")
{
    Console.WriteLine("How much would you like to Withdrawl?");
    double withdraw = double.Parse(Console.ReadLine());
    bankAccount.Withdraw(withdraw);
    Console.WriteLine($"Your balance is now: ${bankAccount.Getbalance()}");
    Console.WriteLine("Thank you for choosing Bengter Bank. Have a great day!");
}

else if (answer == "Deposit")
{
    Console.WriteLine("How much would you like to deposit?");
    double deposit = double.Parse(Console.ReadLine());
    bankAccount.Deposit(deposit);
    Console.WriteLine($"Your balance is now:  ${bankAccount.Getbalance()}");
    Console.WriteLine("Thank you for choosing Bengter Bank. Have a great day!");
}

else
{
    Console.WriteLine("Goodbye");
}







