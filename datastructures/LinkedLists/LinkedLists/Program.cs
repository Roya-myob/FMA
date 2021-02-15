using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.IO.MemoryMappedFiles;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace LinkedLists
    //Get last element
    //Add the new node after the last element
      
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var myList = new LinkedList();

            myList.Add("A");
            myList.Add("B");

            var newLength = myList.GetLength();
           Console.WriteLine(newLength);
        }

    }
  
    class LinkedList
    {
        private Node head; //head of the list 
        
       

        public LinkedList ( )
        {
         
            
        }
        
        

        public void Add(string data)
        {
            // create new node
            // add it to the list

            Node myNode = new Node(data);
            
           
           if(myNode.NextNode == null)
            {
                
                head = myNode;
                myNode.NextNode = null;
                
            }
            else
            {

            }
            


        }

        public int GetLength()
        {
            // 1- head is our first element and we set current to head .... also we can set count to 1 
            // 2- we check if there is any element next to the current element, if yes > we increase the count
            // 3- we need move the current to the next element and go to step 2
            // if the next is null  then stop the count

            var count = 1;
            var current = head;
         
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
