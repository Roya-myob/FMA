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
        //HasElement
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
        public void AddToFront_Should_Add_Node_To_The_List()
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
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddToFront_should_Throw_Exception_If_Data_Is_Null()
        {
            var myList = new LinkedList();
            myList.AddToFront(null);
        }
        
        //NthElement
        [TestMethod]
        public void NthElement_Should_Return_The_Correct_Element()
        {
            //3a: arrange act assert 
            var myList = new LinkedList();
            myList.AddToFront("ABC");
            myList.AddToFront("EFG");
            myList.AddToFront("123");
            myList.AddToFront("#$%");
            
            var result1 = myList.NthElement(4);
            result1.Should().Match("ABC");

            var result2 = myList.NthElement(3);
             result2.Should().Match("EFG");

             var result3 = myList.NthElement(2);
             result3.Should().Match("123");

             var result4 = myList.NthElement(1);
             result4.Should().Match("#$%");

        }
        
        [TestMethod]
        public void NthElement_Should_Return_The_Correct_Element_Even_If_Only_One()
        {
            var myList = new LinkedList();
            myList.AddToFront("ABC");
            var result = myList.NthElement(1);
            result.Should().Match("ABC");

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NthElement_Should_Throw_An_Exception_If_The_Number_Is_Greater_Than_The_Length_Of_The_List()
        {
            var myList = new LinkedList();
            myList.AddToFront("ABC");
            myList.AddToFront("EFG");
            myList.AddToFront("123");
            var result = myList.NthElement(10);
            //result.Should().Contain("Exception");
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NthElement_should_Throw_An_Exceptiopn_If_The_Number_Is_Equal_To_Zero_Or_Less()
        {
            var myList = new LinkedList();
            myList.AddToFront("ABC");
            myList.AddToFront("EFG");
            myList.AddToFront("123");
            var result = myList.NthElement(0);
            result.Should().Contain("Exception");
        }


    }
}