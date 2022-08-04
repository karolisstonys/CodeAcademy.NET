namespace L029_OOP_Microsoft_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var account = new BankAccount("Karolis");

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with balance of {account.Balance}.");


        }
    }
}