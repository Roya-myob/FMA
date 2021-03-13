using System;
using System.Runtime.Remoting.Proxies;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedLists;

namespace LinkedListTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void HasElement_Should_Return_False_If_List_Is_Empty()
        {
            var myList = new LinkedList();
            var result = myList.HasElement("ABCD");
            result.Should().Be(false);

        }

        [TestMethod]
        public void HasElement_should_Return_False_If_Element_Is_Not_In_The_List()
        {
            var myList = new LinkedList();
            myList.AddToFront("ABCD");
            //myList.Add("EFG");
           // myList.Add("QRS");
            var result = myList.HasElement("ZEN");
            result.Should().Be(false);

        }
        
        
        [TestMethod]
        public void HasElement_Should_Return_True_If_Element_Is_In_The_List()
        {
            var myList = new LinkedList();
            myList.AddToFront("ABCD");
            myList.AddToFront("EFG");
            myList.AddToFront("QRS");
            
            var result = myList.HasElement("ABCD");
            result.Should().Be(true);
            
            result = myList.HasElement("EFG");
            result.Should().Be(true);
            
            result = myList.HasElement("QRS");
            result.Should().Be(true);
            
           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HasElement_Should_Throw_Exception_If_Data_Is_Null()
        {
            var myList = new LinkedList();
            var result = myList.HasElement(null);
            
        }
        
        //AddToFront
        [TestMethod]
        public void AddToFront_Should_Return_True_When_Node_Added_To_The_List()
        {
            var myList = new LinkedList();
            myList.AddToFront("ABC");
            myList.AddToFront("EFG");
            myList.AddToFront("123");
            myList.AddToFront("#$%");

            var result = myList.HasElement("#$%");

            result.Should().Be(true);
            
        }
        
        [TestMethod]
        public void AddToFront_Should_Return_False_If_Node_Is_Not_Added_To_The_List()
        {
            var myList = new LinkedList();
            myList.AddToFront("ABC");
            myList.AddToFront("EFG");
            myList.AddToFront("123");
            myList.AddToFront("#$%");

            var result = myList.HasElement("ZEN");

            result.Should().Be(false);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddToFront_should_Throw_Exception_If_Data_Is_Null()
        {
            var myList = new LinkedList();
            myList.AddToFront(null);
        }
        



    }
}