using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factory2 = CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory2;
using Factory3 = CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory3;
using Factory4 = CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory4;

namespace FactoryPattern.Test
{
    /// <summary>
    /// Summary description for PluralsightFactoryPatternTest
    /// </summary>
    [TestClass]
    public class PluralsightFactoryPatternTest
    {
        public PluralsightFactoryPatternTest()
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

        #region Factory2
            
        [TestMethod]
        public void Factory2_AutoFactory_Should_TurnOn_OFF_BMW()
        {
            Factory2.AutoFactory factory = new Factory2.AutoFactory();

            Factory2.IAuto car = factory.CreateInstance("bmw");

            car.TurnOn();
            car.TurnOff();

            Assert.IsInstanceOfType(car, typeof(Factory2.BMW335Xi));
        }

        [TestMethod]
        public void Factory2_AutoFactory_Should_TurnOn_OFF_MiniCooper()
        {
            Factory2.AutoFactory factory = new Factory2.AutoFactory();

            Factory2.IAuto car = factory.CreateInstance("mini");

            car.TurnOn();
            car.TurnOff();

            Assert.IsInstanceOfType(car, typeof(Factory2.MiniCooper));
        }

        #endregion

        #region Factory3
        
        [TestMethod]
        public void Factory3_AutoFactory_Should_TurnOn_OFF_BMW()
        {
            Factory3.IAutoFactory autoFactory = Factory3.CreateFactory.LoadFactory(Properties.Settings.Default.Factory3_BMW);

            Factory3.IAuto car;
            car = autoFactory.CreateAutomobile();

            car.TurnOn();
            car.TurnOff();

            Assert.IsInstanceOfType(car, typeof(Factory3.BMW));
        }

        [TestMethod]
        public void Factory3_AutoFactory_Should_TurnOn_OFF_MiniCooper()
        {
            Factory3.IAutoFactory autoFactory = Factory3.CreateFactory.LoadFactory(Properties.Settings.Default.Factory3_Mini);

            Factory3.IAuto car;
            car = autoFactory.CreateAutomobile();

            car.TurnOn();
            car.TurnOff();

            Assert.IsInstanceOfType(car, typeof(Factory3.MiniCooper));
        }

        #endregion

        #region Factory4

        [TestMethod]
        public void Factory4_AutoFactory_Should_TurnOn_OFF_BMW_SportsCar()
        {
            Factory4.Factory.IAutoFactory autoFactory = Factory4.CreateFactory.LoadFactory(Properties.Settings.Default.Factory4_AutoFactory_BMW);

            Factory4.Autos.IAutomobile car;
            car = autoFactory.CreateSportsCar();

            car.TurnOn();
            car.TurnOff();

            Assert.IsInstanceOfType(car, typeof(Factory4.Autos.BMW.BMWM3));
        }

        [TestMethod]
        public void Factory4_AutoFactory_Should_TurnOn_OFF_BMW_LuxuryCar()
        {
            Factory4.Factory.IAutoFactory autoFactory = Factory4.CreateFactory.LoadFactory(Properties.Settings.Default.Factory4_AutoFactory_BMW);

            Factory4.Autos.IAutomobile car;
            car = autoFactory.CreateLuxuryCar();

            car.TurnOn();
            car.TurnOff();

            Assert.IsInstanceOfType(car, typeof(Factory4.Autos.BMW.BMW740i));
        }

        [TestMethod]
        public void Factory4_AutoFactory_Should_TurnOn_OFF_BMW_EconomyCar()
        {
            Factory4.Factory.IAutoFactory autoFactory = Factory4.CreateFactory.LoadFactory(Properties.Settings.Default.Factory4_AutoFactory_BMW);

            Factory4.Autos.IAutomobile car;
            car = autoFactory.CreateEconomyCar();

            car.TurnOn();
            car.TurnOff();

            Assert.IsInstanceOfType(car, typeof(Factory4.Autos.BMW.BMW328i));
        }

        [TestMethod]
        public void Factory4_AutoFactory_Should_TurnOn_OFF_Mini_SportsCar()
        {
            Factory4.Factory.IAutoFactory autoFactory = Factory4.CreateFactory.LoadFactory(Properties.Settings.Default.Factory4_AutoFactory_Mini);

            Factory4.Autos.IAutomobile car;
            car = autoFactory.CreateSportsCar();

            car.TurnOn();
            car.TurnOff();

            Assert.IsInstanceOfType(car, typeof(Factory4.Autos.Mini.MiniCooper));
        }

        [TestMethod]
        public void Factory4_AutoFactory_Should_TurnOn_OFF_Mini_LuxuryCar()
        {
            Factory4.Factory.IAutoFactory autoFactory = Factory4.CreateFactory.LoadFactory(Properties.Settings.Default.Factory4_AutoFactory_Mini);

            Factory4.Autos.IAutomobile car;
            car = autoFactory.CreateLuxuryCar();

            car.TurnOn();
            car.TurnOff();

            Assert.IsInstanceOfType(car, typeof(Factory4.Autos.Mini.MiniCooper));
        }

        [TestMethod]
        public void Factory4_AutoFactory_Should_TurnOn_OFF_Mini_EconomyCar()
        {
            Factory4.Factory.IAutoFactory autoFactory = Factory4.CreateFactory.LoadFactory(Properties.Settings.Default.Factory4_AutoFactory_Mini);

            Factory4.Autos.IAutomobile car;
            car = autoFactory.CreateEconomyCar();

            car.TurnOn();
            car.TurnOff();

            Assert.IsInstanceOfType(car, typeof(Factory4.Autos.Mini.MiniCooper));
        }
        #endregion
    }
}
