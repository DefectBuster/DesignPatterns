using System.IO;
using System.Threading;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Interfaces;


namespace CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation.FileLoggers
{
    /// <summary>
    /// Base class for all FileLogger implementations
    /// </summary>
    public class BaseFileLogger : IFileLogger
    {
        #region Fields and Constructors
        private readonly IDelayConfig _delayConfig;
        private readonly TextWriter _logfile;
        private const string filePath = @"E:\Study Materials\DesignPattern\DesignPatternSamples\BuildOutput\dev\scratch\logs\logfile.txt";

        public BaseFileLogger() : this(IoC.Resolve<IDelayConfig>())
        {
        }

        public BaseFileLogger(IDelayConfig delayConfig)
        {
            _delayConfig = delayConfig;
            _logfile = GetFileStream();
        }
        #endregion

        public void WriteLineToFile(string value)
        {
            _logfile.WriteLine(value);
        }

        public void CloseFile()
        {
            _logfile.Close();
        }

        protected TextWriter GetFileStream()
        {
            Thread.Sleep(_delayConfig.DelayMilliseconds);
            return TextWriter.Synchronized(File.AppendText(filePath));
        }
    }
}
