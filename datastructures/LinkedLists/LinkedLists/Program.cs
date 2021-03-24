using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.IO.MemoryMappedFiles;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new LinkedList();
            myList.AddToFront("A");
            myList.AddToFront("B");
          
           var myNthElement = myList.NthElement(2);
           
        }
      
    }
  
    public class LinkedList
    {
        private Node head;
        private int length;
        public LinkedList ( )
        {   
            //head is a ref type and if doesn't have a value it will be null by default
            head = null;
            length = 0;
        }
        
        public void AddToFront(string data)
        { 
           if (data == null)
           {
               throw new ArgumentNullException(nameof(data)); 
           }
            
          Node myNode = new Node(data);
          myNode.NextNode = head;
          //  two lines below are not Threat safe - we have to always question it and be aware of it 
          head = myNode;
          length++;
          

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
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
          
           var currentElement = head;
           
           while ( currentElement != null)
           {
               if (currentElement.Data == data)
               {
                   return true;
               }
               else
               {
                   currentElement = currentElement.NextNode;
                   
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
            var count = 1;
            var current  = head;
            var nth = "";
            
            if ( n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            if (n > GetLength())
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }
            
            while (current != null)
            {
              
             if (count == n)
                { 
                  nth = current.Data;
                  break;
                }
     
                else
                {
                    count++;
                    current = current.NextNode;

                }
            }
            return nth;
        }
        
        public int GetLength()
        {
            
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

        public int GetNewLength()
        {   
            return length;
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
