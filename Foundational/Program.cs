using System;
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
            var acc3 = new BankAccount("Barb", "Skeggs");


            BankAccount[] allAccounts = new BankAccount[3];
            allAccounts[0] = acc1;
            allAccounts[1] = acc2;

            for (int i = 0; i < allAccounts.Length; i++)
            {
                if (allAccounts[i] != null)
                {
                    Console.WriteLine("Count["+i+"] - Account Name: " + allAccounts[i].GetFullName());
                }
                
               
            }
            allAccounts[2] = acc3;
            Console.WriteLine("Account location 2 - Account Name: " + allAccounts[2].GetFullName());
            
            for (int i = 0; i < allAccounts.Length; i++)
            {
                if (allAccounts[i] != null)
                {
                    Console.WriteLine("Count["+i+"] - Account Name: " + allAccounts[i].GetFullName());
                }
                
               
            }
        }


        public class BankAccount
        {
            private string _firstName;
            private string _lastName;
            private int _accountNumber;
            private int _balance;
            

           public BankAccount(string firstName, string lastName)
            {

                _firstName = firstName;
                _lastName = lastName;

            }

           public string GetFullName()
           {
               return _firstName + " " + _lastName;
           }
           
            
        }

        
        
    }
}