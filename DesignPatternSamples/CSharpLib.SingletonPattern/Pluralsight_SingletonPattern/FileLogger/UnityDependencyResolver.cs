using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation.Factories;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Interfaces;

using Microsoft.Practices.Unity;

namespace CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger
{
    public class UnityDependencyResolver
    {
        private static readonly IUnityContainer _container;
        static UnityDependencyResolver()
        {
            _container = new UnityContainer();
            IoC.Initialize(_container);
        }

        public void EnsureDependenciesRegistered()
        {
            _container.RegisterType<IFileLoggerFactory, LockedSingletonFileLoggerFactory>();
            _container.RegisterType<IDelayConfig, DefaultDelayConfig>();
        }

        public IUnityContainer Container
        {
            get
            {
                return _container;
            }
        }
    }
}
