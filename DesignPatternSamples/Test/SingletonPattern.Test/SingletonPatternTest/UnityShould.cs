using System.IO;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation.FileLoggers;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation.Factories;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SingletonPattern.Test.SingletonPatternTest
{
    /// <summary>
    /// Summary description for UnityShould
    /// </summary>
    [TestClass]
    public class UnityShould
    {
        private UnityContainer _container;
        [TestInitialize]
        public void Setup()
        {
            _container = new UnityContainer();
            IoC.Initialize(_container);
            _container.RegisterType<IDelayConfig, DefaultDelayConfig>();
        }

        [TestMethod]
        [ExpectedException(typeof(ResolutionFailedException))]
        public void ReturnNewInstanceByDefault()
        {
            _container.RegisterType<IFileLogger, FileLogger>();

            var firstInstance = _container.Resolve<IFileLogger>();
            var secondInstance = _container.Resolve<IFileLogger>();

            Assert.AreNotSame(firstInstance, secondInstance);
        }

        [TestMethod]
        public void ReturnSameInstanceWhenConfiguredToDoSo()
        {
            _container.RegisterType<IFileLogger, FileLogger>(new ContainerControlledLifetimeManager());

            var firstInstance = _container.Resolve<IFileLogger>();
            var secondInstance = _container.Resolve<IFileLogger>();

            Assert.AreSame(firstInstance, secondInstance);
        }
    }
}
