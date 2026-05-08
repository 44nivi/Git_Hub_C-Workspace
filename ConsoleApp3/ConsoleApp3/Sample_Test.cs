using NUnit.Framework;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{   
    class Order
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }

        public Order(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
    class Basic
    {
        public static Func<int, int, int> add = (a, b) => a + b;
        public static Func<int, int, int> mul = (a, b) => a * b;
        public static Func<int, int, int> sub = (a, b) => a - b;
        public static Func<int, int, int> div = (a, b) => a / b;
    }

    internal class Sample_Test
    {
        

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // Code here will run once before any tests in this fixture are executed.
            // Example: Initialize resources needed for all tests.
            Console.WriteLine("OneTimeSetUp: Initialize test suite resources. eg: Initializing a database connection.\r\nStarting a web server.\r\nSetting up a configuration that is used by all tests.");
        }

        [SetUp]
        public void SetUp()
        {
            // Code here will run before each test.
            // Example: Open a web browser and navigate to the Amazon homepage.

            Console.WriteLine("SetUp: Open web browser and navigate to Amazon homepage.");
        }

        [TestCase]
        
        public void SimpleArithmetic()
        {
            int r1 = Basic.add(3, 3);
            Assert.AreEqual(r1, 6);

            int r2 = Basic.sub(3, 3);
            Assert.AreEqual(r2, 0);

            int r3 = Basic.mul(3, 3);
            Assert.AreEqual(r3, 9);

            int r4 = Basic.div(3, 3);
            Assert.AreEqual(r4, 1);
        }


        [TestCase]
        public void Order_Placed()
        {
            Order obj = new Order(001,"nivi","good product");
            int r1=obj.Id;
            Assert.AreEqual(r1,001 );
           
            String r2 = obj.Name;
            Assert.AreEqual(r2, "nivi");

            String r3 = obj.Description;
            Assert.AreEqual(r3, "good product");

        }
        [TearDown]
        public void TearDown()
        {
            // Code here will run after each test.
            // Example: Close the web browser.
            Console.WriteLine("TearDown: Close web browser.");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // Code here will run once after all tests in this fixture have been executed.
            // Example: Clean up any resources initialized in OneTimeSetUp.
            Console.WriteLine("OneTimeTearDown: Clean up test suite resources.");
        }


    }
}
