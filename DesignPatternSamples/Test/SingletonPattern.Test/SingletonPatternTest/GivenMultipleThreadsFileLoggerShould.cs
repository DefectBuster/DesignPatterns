using System.IO;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation.Factories;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SingletonPattern.Test.SingletonPatternTest
{
    /// <summary>
    /// Summary description for GivenMultipleThreadsFileLoggerShould
    /// </summary>
    [TestClass]
    public class GivenMultipleThreadsFileLoggerShould
    {
        private IUnityContainer _container;
        private INumbersToTextFile _numbersToTextFile;

        [TestInitialize]
        public void Setup()
        {
            File.Delete(@"E:\Study Materials\DesignPattern\DesignPatternSamples\BuildOutput\dev\scratch\logs\logfile.txt");
            _container = new UnityContainer();
            _container.RegisterType<INumbersToTextFile, NumbersToTextFileAsync>();
            _container.RegisterType<IDelayConfig, TestDelayConfig>();
            IoC.Initialize(_container);
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

        [TestCleanup]
        public void CleanUp()
        {
            //File.Delete(@"c:\logfile.txt");
        }

        private void LogNumbers()
        {
            _numbersToTextFile = _container.Resolve<INumbersToTextFile>();
            _numbersToTextFile.MaxIntegerToWrite = 1000;
            _numbersToTextFile.WriteNumbersToFile();
        }

        [TestMethod]
        public void LogNumbersWithInstanceFileLogger()
        {
            _container.RegisterType<IFileLoggerFactory, InstanceFileLoggerFactory>();
            LogNumbers();
        }

        [TestMethod]
        public void LogNumbersWithSingletonFileLogger()
        {
            _container.RegisterType<IFileLoggerFactory, SingletonFileLoggerFactory>();
            LogNumbers();
        }

        [TestMethod]
        public void LogNumbersWithLockedSingletonFileLogger()
        {
            _container.RegisterType<IFileLoggerFactory, LockedSingletonFileLoggerFactory>();
            LogNumbers();
        }

        [TestMethod]
        public void LogNumbersWithDoubleCheckLockedSingletonFileLogger()
        {
            _container.RegisterType<IFileLoggerFactory, DoubleCheckLockedSingletonFileLoggerFactory>();
            LogNumbers();
        }

        [TestMethod]
        public void LogNumbersWithLazySingletonFileLogger()
        {
            _container.RegisterType<IFileLoggerFactory, LazySingletonFileLoggerFactory>();
            LogNumbers();
        }
    }
}
