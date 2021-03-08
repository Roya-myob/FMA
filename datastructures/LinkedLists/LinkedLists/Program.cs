using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.IO.MemoryMappedFiles;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

//write some unit tests
// then fix the issues

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var myList = new LinkedList();

           // myList.AddTOEND("A");
            //myList.AddTOEND("B");
            //myList.AddTOEND("C");
         
            myList.Add("A");
            myList.Add("B");
            myList.Add("C");
            myList.Add("D");
            
            var myElement = myList.HasElement("A");
           //var myNthElement = myList.NthElement(2);

            var newLength = myList.GetLength();
            Console.WriteLine("Has Element: " + myElement);
           // Console.WriteLine("Length is: " + newLength);
           //Console.WriteLine("nth Element is " + myNthElement );
        }
    }
  
    public class LinkedList
    {
        private Node head;

        public LinkedList ( )
        {
            head = null;
        }
        
        public void Add(string data)
        {
          Node myNode = new Node(data);
          myNode.NextNode = head;
          head = myNode;
          //Console.WriteLine(head);

        }
        public void AddTOEND(string data)
        {
            Node myNode = new Node(data);
            myNode.NextNode = head;
            while (myNode.NextNode == null)
            {
                myNode.NextNode = myNode;
                head = myNode;
            }
            
        }
          
        public bool HasElement(string data)
        {
           //1- go the each node that is added already in the list
           //2- check if the element that we are looking for exist in that node 
           //3- if exist the return true
           //4- if does not exist , we go to the next node
           var currentElement = head;
           // if (currentElement.NextNode == null)
           // {
           //     if (currentElement.Data == data)
           //     {
           //         return true;
           //     }
           // }
           if (head == null)
           {
               return false;

           }

           ; 
           while ( currentElement.NextNode != null)
           {
               if (currentElement.Data == data)
               {
                   return true;
               }
               else
               {
                   currentElement = currentElement.NextNode;
                   // if (currentElement.Data == data)
                   // {
                   //     return true;
                   // }
               }

           }
           
           return false;

        }

        public string NthElement(int n)
        {
            // input is number and output is the Node
            // eg 2 => B
            //start from first of the list which is head
            // count from 0 and increment with the number of nodes 
            // return the node that matches the number
            var count = 0;
            
            var current  = head;
            while (current.NextNode != null)
            {
              
             if (count == n)
                {
                    
                    var nth = current.Data;
                    //return myNthElement;
                    Console.WriteLine("Nth element is : " + nth);
                   // break;
                }
                else
                {
                    count++;
                    current = current.NextNode;

                }
            }


            return current.Data;
            




        }
        
        public int GetLength()
        {
            // 1- head is our first element and we set current to head .... also we can set count to 1 
            // 2- we check if there is any element next to the current element, if yes > we increase the count
            // 3- we need move the current to the next element and go to step 2
            // if the next is null  then stop the count
            
            var count = 1;
            var current = head;
            if (current == null)
            {
                return 0;
            }
            while(current.NextNode != null){
                count++;
                current = current.NextNode;
            }

            return count;
        }
       
    }

    class Node
    {
        
        public string Data;
        public Node NextNode;
        
        public Node(string data)
        {
            Data = data;
            NextNode = null;
            
        }
    }

   

}
