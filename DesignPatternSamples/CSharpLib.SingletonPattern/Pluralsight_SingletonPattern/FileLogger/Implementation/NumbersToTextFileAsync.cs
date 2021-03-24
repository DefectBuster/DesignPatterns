using System;
using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Interfaces;
using System.Threading.Tasks;

namespace CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation
{
    public class NumbersToTextFileAsync : INumbersToTextFile
    {
        private readonly IFileLoggerFactory _fileLoggerFactory;
        public NumbersToTextFileAsync(IFileLoggerFactory fileLoggerFactory)
        {
            _fileLoggerFactory = fileLoggerFactory;
        }

        public void WriteNumbersToFile()
        {
            Console.WriteLine("Begin Logging to File");
            var generator = new NumberGenerator();
            IFileLogger myLogger = null;

            Action<int> logToFile = i =>
            {
                Console.Write(".");
                myLogger = _fileLoggerFactory.Create();
                myLogger.WriteLineToFile("Getting next number...");
                myLogger.WriteLineToFile("Logged Number: " + i);

            };
            Parallel.For(0, _maxIntegerToWrite, logToFile);

            myLogger.CloseFile();
            Console.WriteLine();
        }

        private int _maxIntegerToWrite = 100;
        public int MaxIntegerToWrite
        {
            set { _maxIntegerToWrite = value; }
        }
    }
}
