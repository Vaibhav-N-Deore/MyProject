/*using MyProject.Oops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyProject.ArrayObject.TwoDArray.Project;
using static MyProject.ArrayObject.TwoDArray.School;

namespace MyProject.ArrayObject.TwoDArray
{
    internal class Project  //format
    {
        class Account
        {
            string AccountName;
            int AccountId;
            string AccountType;
            int AccountBalance;
           public Account[] account;

            public Account()
            {
                account = new Account[100];
                AccountId = 0;

            }
            public Account(int account_id, string authorname, String account_type, int accountbalance)
            {

            }
            public void CreaeAccount(Account a)
            {
                this.account = a;
            }
            public override string ToString()
            {
                return AccountId + " " + AccountName + " " + AccountType + " " + AccountBalance;
            }
            public void ShowAllAccount()
            {
                //display all records from account array
            }
            public void ShowAccountById(int id)
            {
                foreach (Account bt in account)
                {
                    if (bt != null)
                    {
                        if (id == bt.AccountId)
                        {
                            Console.WriteLine(bt);
                        }
                    }
                }

            }
            public void UpdateAccount(int id)
            {

                if (AccountId >= account.Length)
                {
                    Console.WriteLine("Error: maximum number of students reached");
                    return;
                }

                account[AccountId] = id;
                AccountId++;

            }
            public void DeleteAccount(int id)
            {

                for (int i = 0; i < AccountId; i++)
                {
                    if (account[i].Id == id)
                    {
                        for (int j = i; j < AccountId - 1; j++)
                        {
                            AccountId[j] = AccountId[j + 1];
                        }
                        AccountId[AccountId - 1] = null;
                        AccountId--;
                        return;
                    }
                }

                Console.WriteLine("Error: account with ID " + id + " not found");
            }
             for (int i = index; i<AccountId - 1; i++)
            {
                Account[i] = Account[i + 1];
            }
                 account[accountid - 1] = null;
                 numStudents--;


    }

    public class Student
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public int Type { get; set; }
                public double Balance { get; set; }
            }
            class Project
            {
                static void Main(string[] args)
                {
                    Account[] b = new Account[3]; 

                    //logic too create array

                    Account bk = new Account(); 
                    bk.CreatAccountId(b); 
                    bk.ShowAllAccount(); 
                    bk.ShowAccountById(100);

                }
            }
    }
}
                    

                












*/