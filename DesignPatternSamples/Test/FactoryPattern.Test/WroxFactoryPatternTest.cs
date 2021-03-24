using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpLib.FactoryPattern.Wrox_FactorySample;

namespace FactoryPattern.Test
{
    /// <summary>
    /// Summary description for WroxFactoryPatternTest
    /// </summary>
    [TestClass]
    public class WroxFactoryPatternTest
    {
        public WroxFactoryPatternTest()
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
        public void UKShippingCourierFactory_Should_Create_DHLShippingCourier_WithTotalCost_Over100()
        {
            Order order = new Order() { TotalCost = 101 };

            IShippingCourier courier = UKShippingCourierFactory.CreateShippingCourier(order);

            Assert.IsInstanceOfType(courier, typeof(DHL));
            //OR below way
            //Assert.IsTrue(typeof(DHL).IsInstanceOfType(courier));
        }

        [TestMethod]
        public void UKShippingCourierFactory_Should_Create_DHLShippingCourier_WithWeightInKG_Over5()
        {
            Order order = new Order() { WeightInKG = 6 };

            IShippingCourier courier = UKShippingCourierFactory.CreateShippingCourier(order);

            Assert.IsInstanceOfType(courier, typeof(DHL));
            //OR below way
            //Assert.IsTrue(typeof(DHL).IsInstanceOfType(courier));
        }

        [TestMethod]
        public void UKShippingCourierFactory_Should_Create_RoyalMailShippingCourier_WithWeightInKG_Under5()
        {
            Order order = new Order() { WeightInKG = 5 };

            IShippingCourier courier = UKShippingCourierFactory.CreateShippingCourier(order);

            Assert.IsInstanceOfType(courier, typeof(RoyalMail));
            //OR below way
            //Assert.IsTrue(typeof(DHL).IsInstanceOfType(courier));
        }

        [TestMethod]
        public void UKShippingCourierFactory_Should_Create_RoyalMailShippingCourier_WithTotalCost_Under100()
        {
            Order order = new Order() { TotalCost = 100 };

            IShippingCourier courier = UKShippingCourierFactory.CreateShippingCourier(order);

            Assert.IsInstanceOfType(courier, typeof(RoyalMail));
            //OR below way
            Assert.IsTrue(typeof(RoyalMail).IsInstanceOfType(courier));
        }
    }
}
