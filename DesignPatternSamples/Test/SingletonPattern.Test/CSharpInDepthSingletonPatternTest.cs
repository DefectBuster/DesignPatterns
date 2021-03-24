using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpInDepth = CSharpLib.SingletonPattern.CSharpInDepth_SingletonPattern;

namespace SingletonPattern.Test
{
    /// <summary>
    /// Summary description for CSharpInDepthSingletonPatternTest
    /// </summary>
    [TestClass]
    public class CSharpInDepthSingletonPatternTest
    {
        public CSharpInDepthSingletonPatternTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


        [TestMethod]
        public void Singleton_NotThreadSafe_Should_Display_Same_Value_ForTwoInstance()
        {
            CSharpInDepth._1_NotThreadSafe.Singleton firstInstance = CSharpInDepth._1_NotThreadSafe.Singleton.GetInstance;
            firstInstance.Value = 5;

            CSharpInDepth._1_NotThreadSafe.Singleton secondInstance = CSharpInDepth._1_NotThreadSafe.Singleton.GetInstance;

            firstInstance.DisplayValue();
            secondInstance.DisplayValue();

            Assert.AreEqual(firstInstance.Value, secondInstance.Value);

        }

        [TestMethod]
        public void Singleton_ThreadSafeWithoutUsingLock_Should_Display_Same_Value_ForTwoInstance()
        {
            CSharpInDepth._4_ThreadSafeWithoutUsingLock.Singleton firstInstance = CSharpInDepth._4_ThreadSafeWithoutUsingLock.Singleton.GetInstance;
            firstInstance.Value = 5;

            CSharpInDepth._4_ThreadSafeWithoutUsingLock.Singleton secondInstance = CSharpInDepth._4_ThreadSafeWithoutUsingLock.Singleton.GetInstance;

            firstInstance.DisplayValue();
            secondInstance.DisplayValue();

            Assert.AreEqual(firstInstance.Value, secondInstance.Value);
        }
    }
}
