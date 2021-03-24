using InstanceFileLogger=CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation.FileLoggers;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Interfaces;

namespace CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation.Factories
{
    public class InstanceFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return new InstanceFileLogger.FileLogger();
        }
    }
}
