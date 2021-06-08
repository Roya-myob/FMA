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
            var acc1 = new BankAcc("Kate","Walsh");
            var acc2 = new BankAcc("Nick", "Shepherd");
            var acc3 = new BankAcc("Barb", "Skeggs");


            BankAcc[] allAccounts = new BankAcc[] {acc1, acc2};

            for (int i = 0; i < allAccounts.Length; i++)
            {
                Console.Write(allAccounts[i] + "Should be acc 1 and 2");
                allAccounts[2] = acc3;
                Console.Write(allAccounts[2] + " Should be acc 1, 2, 3 ");

            


        }
        public class BankAcc
        {
            private string _firstName;
            private string _lastName;
            private int _accNumber;
            private int _balance;
            

           public BankAcc(string firstName, string lastName)
            {

                _firstName = firstName;
                _lastName = lastName;

            }
           
           
            
        }

        
        
    }
}