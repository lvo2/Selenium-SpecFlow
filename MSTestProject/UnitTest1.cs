using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestProject
{
    [TestClass] //this is used for test class
    public class UnitTest1
    {
        [ClassInitialize]
        public static void BeforeClass(TestContext tc)
        {
            Console.WriteLine("This is Before Class");
        }

        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("This is After Class");            
        }

        [TestInitialize]
        public void BeforeTest()
        {
            Console.WriteLine("This is Before Test");
        }

        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("This is After Test");
        }

        [TestMethod]  //this is used to declare method as test method
        public void TestMethod1()
        {
            Console.WriteLine("This is Test Method 1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("This is Test Method 2");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("This is Test Method 3");
        }
    }
}
