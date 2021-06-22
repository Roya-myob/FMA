using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;

namespace Foundational
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var acc1 = new BankAccount("Kate", "Walsh");
            var acc2 = new BankAccount("Nick", "Shepherd");
            var acc3 = new BankAccount("Barb", "Skeggs");
           // var acc4 = new BankAccount("R","T");
            
            Hashtable ht = new Hashtable();
            ht.Add("Kate", acc1);
            ht.Add("Nick", acc2);
            ht.Add("Barb", acc3);
            ht.Add( "Roya", null); // value can be null
            ht.Add(1, "hello"); // different data tyoe
            ht.Add(2, 340.07);
           
            // null ref if set to undefined key
            Console.WriteLine(((BankAccount) ht["Kate"]).GetFullName());
            

            ICollection keys = ht.Keys;
            
            foreach (var k in keys) {
                Console.WriteLine(" key value = " + k);
                //Console.WriteLine(((BankAccount) ht[k]).GetFullName());
            }
            
            
            
        }


        public class BankAccount
        {
            static string _firstName;
            static string _lastName;
            private int _accountNumber;
            private int _balance;
            

           public BankAccount(string firstName, string lastName)
            {

                _firstName = firstName;
                _lastName = lastName;

                getFullName = () => Console.WriteLine("no");

                if (true)
                {
                    getFullName = () => Console.WriteLine("yes");
                }

                getFullName();
            }

           /*public string GetFullName()  
           {
               return _firstName + " " + _lastName;
           }*/
           
          // Func<double, double> square = static x => x * x;
       
          // public string () => _firstName + " " + _lastName;
          

        }

        
        
    }
}