using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //Lägg till Egenskaper (fields)
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        //Lägg till Konstruktor
        public BankAccount(string number, string holder, double balance)
        {
            AccountNumber = number;
            AccountHolder = holder;
            Balance = balance;
        }
        //Lägg till Metoder
        public double Deposit(double deposit)
        {
            Console.WriteLine($"Deposited: {deposit}");
            return Balance += deposit;
        }
        public double Withdraw(double withdrawal)
        {
            Console.WriteLine($"Withdrew: {withdrawal}");
            return Balance -= withdrawal;
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }
        //Lycka till! :)
    }
}
