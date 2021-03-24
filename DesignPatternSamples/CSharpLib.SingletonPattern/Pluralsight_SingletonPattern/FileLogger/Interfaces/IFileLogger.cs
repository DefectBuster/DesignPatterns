namespace CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Interfaces
{
    public interface IFileLogger
    {
        void WriteLineToFile(string value);
        void CloseFile();
    }
}
