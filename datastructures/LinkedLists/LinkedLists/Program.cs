using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var lawrenceAddress = new Address("Pearce St", "B Hills", "2153");

            //var new Address("Not my address", lawrenceAddress.Line2, lawrenceAddress.PostCode);
            //lawrenceAddress.Line1 = "Not my address";

            //Console.WriteLine(lawrenceAddress.Line1);

            // TODO
            // Create Node B (points to null)

            // Create Node A pointing to Node B
        }

    }

    class LinkedList
    {

    }

    class Node
    {
        //property - implicit backing field
        public string Data { get; }
        public string NextNode { get; }

        public Node(string data, string nextNode)
        {
            Data = data;
            NextNode = nextNode;
        }
    }

    public class Address
    {
        public string Line1 { get; }

        public string Line2 { get; }

        public string PostCode { get; }

        public Address(string line1, string line2, string postCode)
        {
            // if line1 contains postcode
            // { split line1 into line 2 and postcode}
            // else
            Line1 = line1;
            Line2 = line2;
            PostCode = postCode;
        }
    }

}
