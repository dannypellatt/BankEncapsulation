using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public double Deposit(double x)
        {
            Console.WriteLine("Please enter the ammount you would like to deposit: ");
            x = Convert.ToDouble(Console.ReadLine());
            balance += x;
            return balance;
        }

        public double Withdraw(double x)
        {
            Console.WriteLine("Please enter the ammount you would like to withdraw: ");
            x = Convert.ToDouble(Console.ReadLine());
            balance -= x;
            return balance;
        }

        public void GetBalance()
        {
            Console.WriteLine(balance);
        } 
    }
}

