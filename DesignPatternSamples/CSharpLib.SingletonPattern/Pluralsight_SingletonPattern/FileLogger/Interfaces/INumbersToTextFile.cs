namespace CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Interfaces
{
    public  interface INumbersToTextFile
    {
        void WriteNumbersToFile();
        int MaxIntegerToWrite { set; }
    }
}
