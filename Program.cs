using System;
namespace BankEncapsulation
{
    class program
    {
        public static void Main(string[] args)
        {
           BankAccount myChaseAccount = new BankAccount();

            Console.WriteLine("What is your deposit today?");
            var myDeposit = double.Parse(Console.ReadLine());
            myChaseAccount.Deposit(myDeposit);
          
            // this gets the balance
            myChaseAccount.GetBalance();
            
            
            Console.WriteLine($"You Deposited ${myDeposit},Your Current Balance is ${myChaseAccount.GetBalance()}"); 
            
     

        }
    }
}




