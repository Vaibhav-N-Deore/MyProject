using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject.TwoDArray
{
    internal class Account
    {
        public Account()
        {
            Console.WriteLine("Account Detail");
        }

        int AccountId;
        string AccountName;
        string AccountType;
        int AccountBalance;
        public void insert()
        {
            Console.WriteLine("Enter Account Number");
            AccountId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Name");
            AccountName = Console.ReadLine();

            Console.WriteLine("Enter Account Type");
            AccountType = Console.ReadLine();

            Console.WriteLine("Enter Account Balance");
            AccountBalance = Convert.ToInt32(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("Account Id " + AccountId);
            Console.WriteLine("Account Name " + AccountName);
            Console.WriteLine("Account Type " + AccountType);
            Console.WriteLine("Account Balance " + AccountBalance);

        }

      
        public void withdraw()
        {
            Console.WriteLine("Enter Withdraw Amount");
            int wamt = Convert.ToInt32(Console.ReadLine());
            if (AccountBalance <= wamt)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                AccountBalance = AccountBalance - wamt;
                Console.WriteLine("Withdraw Amount Successful after withdraw Amount is " + AccountBalance);
            }

        }
        public void deposit()
        {
            Console.WriteLine("Enter Amount to Deposit");
            int deposit = Convert.ToInt32(Console.ReadLine());

            AccountBalance = AccountBalance + deposit;
            Console.WriteLine("After Deposite Balance is " + AccountBalance);
        }
        static void Main(string[] args)
        {
            Account a = new Account();
            a.insert();
            a.display();
            a.withdraw();
            a.deposit();
            Console.ReadLine();
        }
   }
}

   


