using System.ComponentModel.DataAnnotations;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            BankAccount bank = new BankAccount("123456789" , "Anna", 10000);
            
            bank.Deposit(500);
            
            bank.Withdraw(60);

            bank.DisplayBalance();

        }
    }
}
