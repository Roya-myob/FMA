using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Management.Instrumentation;

namespace Foundational
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var acc1 = new BankAccount("Kate", "Walsh");
            var acc2 = new BankAccount("Nick", "Shepherd");
            var acc3 = new BankAccount("Barb", "Skg");
            BankAccount acc4 = new BankAccount("Simon","Chan");
            acc4.Balance = 5;
            Console.WriteLine("acc4 balance is --->> "+ acc4.Balance);
            

            List<BankAccount> allAccounts = new List<BankAccount>();
            allAccounts.Add(acc1);
            allAccounts.Add(acc2);
            
            
            for (int i = 0; i < allAccounts.Count; i++)
            {
                if (allAccounts[i] != null)
                {
                    Console.WriteLine("Count["+i+"] - Account Name: " + allAccounts[i].GetFullName());
                }
                
               
            }
            allAccounts.Add(acc3);
            Console.WriteLine("Count[#2] - Account Name: " + allAccounts[2].GetFullName());
            
            
        }


        public class BankAccount
        {
            private string _firstName;
            private string _lastName;
            private int _accountNumber;
            
            public int Balance
            { get; set; }

           public BankAccount(string firstName, string lastName)
            {

                _firstName = firstName;
                _lastName = lastName;

            }

           public string GetFullName()
           {
               return _firstName + " " + _lastName  ;
           }
           
            
        }

        
        
    }
}